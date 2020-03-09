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
    public partial class Login : Form
    {
        //for moving form
        private Point MouseDownLocation;


        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");
        //for decoding password in database
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //for superAdmin
            if (txtuser.Text.Equals("SuperAdmin") && txtpass.Text.Equals("superadmin"))
            {
                //for changing form
                MessageBox.Show("Welcome Admin");
                this.Hide();
                new ChoiceAccess().Show();
            }

            //for admin
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE Username='" + txtuser.Text + "' AND Password='" + Base64Encode(txtpass.Text) + "' ";
            MySqlDataReader sqlDataReader = null;
            sqlDataReader = cmd.ExecuteReader();

            if (sqlDataReader.Read())
            {
               
                //for changing form
                MessageBox.Show("Welcome Admin");
                this.Hide();        
                new ChoiceAccess().Show();
               
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
            sqlDataReader.Close();
            con.Close();
           
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

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (txtpass.Text == "Password")
                {
                    txtpass.Clear();
                    txtpass.PasswordChar = '*';
                    txtpass.ForeColor = Color.White;
                }
            }
        }
    }
}
