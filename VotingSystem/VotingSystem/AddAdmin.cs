using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace VotingSystem
{
    public partial class AddAdmin : Form
    {
        //for moving form
        private Point MouseDownLocation;

        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");

        //for inserting in database(encrypted password)
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        //for inserting in database query
        private void executeQuery(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Registered");
                }
                else
                {
                    MessageBox.Show("Failed to executed");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
                    
            }
        }

        public AddAdmin()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Username";
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Clear();
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Clear();
                txtpass.PasswordChar = '*';
                txtpass.ForeColor = Color.White;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.PasswordChar = '\0';
                txtpass.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Confirm Password")
            {
                txtConfirmPass.Clear();
                txtConfirmPass.PasswordChar = '*';
                txtConfirmPass.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "")
            {
                txtConfirmPass.Text = "Confirm Password";
                txtConfirmPass.PasswordChar = '\0';
                txtConfirmPass.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text != txtpass.Text)
            {
                MessageBox.Show("Please Check your password");
            }
            else
            {
                String sql = "INSERT INTO tbl_admin(Username,Password)VALUES('"+txtuser.Text+"','"+ Base64Encode(txtpass.Text) + "')";
                executeQuery(sql);
            }
           
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (txtuser.Text == "Username")
                {
                    txtuser.Clear();
                    txtuser.ForeColor = Color.White;
                }
            }
        }

        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Tab)
            {
                if (txtpass.Text == "Password")
                {
                    txtpass.Clear();
                    txtpass.PasswordChar = '*';
                    txtpass.ForeColor = Color.White;
                }
            }
        }

        private void txtConfirmPass_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                if (txtConfirmPass.Text == "Confirm Password")
                {
                    txtConfirmPass.Clear();
                    txtConfirmPass.PasswordChar = '*';
                    txtConfirmPass.ForeColor = Color.White;
                }
            }
        }
    }
}
