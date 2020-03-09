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

    public partial class AdminModule : Form
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
        //for partylist1 table
        private void updateTable()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tbl_candidates.Candidate_id as 'Candidate ID', tbl_candidates.Candidate_Name as 'Candidate Name', tbl_candidates.Candidate_Position as 'Candidate Position', tbl_votes.Number_Of_Votes from tbl_candidates inner join tbl_votes on tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE tbl_candidates.Candidate_Party='Partylist1' ", con);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "votes");
                dataGridView1.DataSource = ds.Tables["votes"];
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //for partylist2 table
        private void updateTable1()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT tbl_candidates.Candidate_id as 'Candidate ID', tbl_candidates.Candidate_Name as 'Candidate Name', tbl_candidates.Candidate_Position as 'Candidate Position', tbl_votes.Number_Of_Votes from tbl_candidates inner join tbl_votes on tbl_candidates.Candidate_id = tbl_votes.Candidate_ID WHERE tbl_candidates.Candidate_Party='Partylist2' ", con);
                openConnection();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "votes");
                dataGridView2.DataSource = ds.Tables["votes"];
                closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public AdminModule()
        {
            InitializeComponent();
            //for partylist1
            updateTable();

            dataGridView1.Columns[0].Width = (200);
            dataGridView1.Columns[1].Width = (380);
            dataGridView1.Columns[2].Width = (380);
            dataGridView1.Columns[3].Width = (200);
            //for partylist2
            updateTable1();

            dataGridView2.Columns[0].Width = (200);
            dataGridView2.Columns[1].Width = (380);
            dataGridView2.Columns[2].Width = (380);
            dataGridView2.Columns[3].Width = (200);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminModule_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 64, 83);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Regular);

            //mema
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 64, 83);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Regular);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new CsgWinners().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Ballot().Show();
        }

        private void President_Click(object sender, EventArgs e)
        {
            new AddCandidate().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddAdmin().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            updateTable();
            updateTable1();
        }
    }
}
