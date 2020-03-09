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
    public partial class AddCandidate : Form
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
                    MessageBox.Show("Candidate Added");
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
        //for inserting candidate info
        private void InsertCandidate(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //nothing to display
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
        //for inserting achievements
        private void InsertingAchievements(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //nothing to display
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
        //for inserting Platform
        private void InsertingPlatform(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //nothing to display
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

        public AddCandidate()
        {
            InitializeComponent();
            //txtuser.BorderStyle = BorderStyle.None;
            //AutoSize = false;
            //txtuser.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            //txtnickname.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

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

        private void AddCandidate_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getText = txtAchievement.Text;
            listView1.Items.Add(getText);
            txtAchievement.Text = null;
        }
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tbl_candidates where candidate_position = '" + cmbPosition.SelectedItem.ToString() + "' AND Candidate_party = '" + cmbPartylist.SelectedItem.ToString() + "'" ;
            MySqlDataReader sqlDataReader = null;
            sqlDataReader = cmd.ExecuteReader();
           
            if (!sqlDataReader.HasRows)
            {              
                con.Close();
                //for inserting info
                String sql = "INSERT INTO tbl_candidates(Candidate_Name,Candidate_Nickname,Candidate_Position,Candidate_Party)VALUES ('" + txtfullname.Text + "','" + txtnick.Text + "','" + cmbPosition.SelectedItem.ToString() + "','" + cmbPartylist.SelectedItem.ToString() + "')";
                InsertCandidate(sql);

                //for inserting achievements
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    String sql1 = "INSERT INTO tbl_candidate_achievement values('', '" + listView1.Items[i].Text + "', (SELECT MAX(Candidate_ID)FROM tbl_candidates)) ";
                    InsertingAchievements(sql1);
                }
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    String sql2 = "INSERT INTO tbl_candidate_platform values('', '" + listView2.Items[i].Text + "', (SELECT MAX(Candidate_ID)FROM tbl_candidates)) ";
                    InsertingPlatform(sql2);
                }

                String sql3 = "INSERT INTO tbl_votes(Candidate_ID,NUMBER_of_Votes)VALUES ((SELECT MAX(Candidate_ID)FROM tbl_candidates), 0)";
                InsertingPlatform(sql3);

                MessageBox.Show("Candidate Added");
                txtfullname.Text = null;
                txtnick.Text = null;
                txtAchievement.Text = null;
                txtPlatform.Text = null;
                listView1.Items.Clear();
                listView2.Items.Clear();
                cmbPartylist.SelectedIndex = -1;
                cmbPosition.SelectedIndex = -1;
            }                 
            else
            {
                MessageBox.Show("Position is already taken in the chosen partylist");
            }

            sqlDataReader.Close();
            con.Close();
            //dito mag nanull lahat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string getText = txtPlatform.Text;
            listView2.Items.Add(getText);
            txtPlatform.Text = null;
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {
                    listView1.SelectedItems[0].Remove();
                }
            }
        }

        private void listView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView2.Items.Count > 0)
            {
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {
                    listView2.SelectedItems[0].Remove();
                }
            }
        }
    }
}
