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
    public partial class AddStudent : Form
    {
        //for moving form
        private Point MouseDownLocation;
        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");

        //for executing Query
        private void executeQuery(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully executed");
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

        public AddStudent()
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO tbl_students(student_number,Program,hasVoted)VALUES('"+txtStudentNumber.Text+"','"+cmbProgram.SelectedItem.ToString()+"',0) ";
            executeQuery(sql);
            txtStudentNumber.Text = null;
            cmbProgram.SelectedIndex = -1;
        }
    }
}
