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
    public partial class CsgWinners : Form
    {
        //for moving form
        private Point MouseDownLocation;

        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");

        //for opening connection
        private void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //for closing connection
        private void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //for updating table
        private void updateTable()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("(SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position as " +
                    "'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON " +
                    "tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes)" +
                    " AND tbl_candidates.Candidate_Position='President' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION (SELECT tbl_candidates.Candidate_Name " +
                    "as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party'," +
                    " tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID " +
                    "WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND tbl_candidates.Candidate_Position='Vice President For Academic Affairs' " +
                    "ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION(SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position " +
                    "as 'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON " +
                    "tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) " +
                    "AND tbl_candidates.Candidate_Position='Vice President For Internal Affairs' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) " +
                    "UNION (SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position'," +
                    " tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON " +
                    "tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) " +
                    "AND tbl_candidates.Candidate_Position='Vice President For External Affairs' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION " +
                    "(SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position', tbl_candidates.Candidate_Party " +
                    "as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID " +
                    "WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND tbl_candidates.Candidate_Position='Vice President For Operations' " +
                    "ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION (SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position " +
                    "as 'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN " +
                    "tbl_votes ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND" +
                    " tbl_candidates.Candidate_Position='Vice President For Finance' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) " +
                    "UNION (SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position', " +
                    "tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes " +
                    "ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND " +
                    "tbl_candidates.Candidate_Position='ICT Representative' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION (SELECT tbl_candidates.Candidate_Name " +
                    "as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position', tbl_candidates.Candidate_Party as 'Candidate_Party', " +
                    "tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE" +
                    "(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND tbl_candidates.Candidate_Position='Engineering Representative' ORDER BY " +
                    "tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION (SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position " +
                    "as 'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes " +
                    "ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND " +
                    "tbl_candidates.Candidate_Position='Accountancy, Business & Management Representative' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION " +
                    "(SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position as 'Candidate_Position',tbl_candidates.Candidate_Party " +
                    "as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID " +
                    "WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) AND tbl_candidates.Candidate_Position='Tourism & Hospitality Management Representative' " +
                    "ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) UNION (SELECT tbl_candidates.Candidate_Name as 'Candidate_Name', tbl_candidates.Candidate_Position " +
                    "as 'Candidate_Position',tbl_candidates.Candidate_Party as 'Candidate_Party', tbl_votes.Number_Of_Votes FROM tbl_candidates INNER JOIN tbl_votes " +
                    "ON tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE(SELECT MAX(tbl_votes.Number_Of_Votes) FROM tbl_votes) " +
                    "AND tbl_candidates.Candidate_Position='Arts & Sciences Representative' ORDER BY tbl_votes.Number_Of_Votes DESC LIMIT 1) ", con);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "winners");
                dataGridView1.DataSource = ds.Tables["winners"];
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public CsgWinners()
        {
            InitializeComponent();
            updateTable();
            dataGridView1.Columns[0].Width = (200);
            dataGridView1.Columns[1].Width = (380);
            dataGridView1.Columns[2].Width = (380);
            dataGridView1.Columns[3].Width = (200);
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

        private void CsgWinners_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 64, 83);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Regular);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new AdminModule().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
