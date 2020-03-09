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
    public partial class StudentNumber : Form
    {
        //for moving form
        private Point MouseDownLocation;
        public static Ballot ballot = new Ballot();
        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");

        public StudentNumber()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void StudentNumber_Load(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tbl_students WHERE student_number='" + txtStudentNumber.Text + "' ";
                    MySqlDataReader sqlDataReader = null;
                    sqlDataReader = cmd.ExecuteReader();
                    Byte hasVoted = 0;


                    if(sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            hasVoted = sqlDataReader.GetByte("hasVoted");
                        }

                        if (hasVoted == 0)
                        {
                            
                            ballot.Show();
                            ballot.checkProgram(txtStudentNumber);
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Sorry You Already Voted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input properly your Student Number or ask the Electoral tribunals.");
                    }
                    sqlDataReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please input properly your Student Number or ask the Electoral tribunals.");
                }
                con.Close();
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
    }
}
