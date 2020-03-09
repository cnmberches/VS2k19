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
    public partial class Confirmation : Form
    {
        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");

        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            txtPres.Text = theGetter.getCandidatePres;
            txtVPacademic.Text = theGetter.getAcademic;
            txtVPInternal.Text = theGetter.getCandidateInternal;
            txtVPExternal.Text = theGetter.getCandidateExternal;
            txtVPOperation.Text = theGetter.getOperation;
            txtVPFinance.Text = theGetter.getFinance;

            txtDepartment.Text = theGetter.getDepartment;
            txtRep.Text = theGetter.getRepresentative;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            StudentNumber.ballot.Show();
        }

        private void vote_party1_btn_Click(object sender, EventArgs e)
        {
            con.Close();
            for (int i = 0; i < 7; i++)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tbl_votes SET NUMBER_OF_VOTES = NUMBER_OF_VOTES + 1 WHERE CANDIDATE_ID = " + theGetter.getId[i], con);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd1 = new MySqlCommand("UPDATE tbl_students SET hasvoted = true WHERE student_number = " + theGetter.getStudentNumber, con);
                cmd1.ExecuteNonQuery();
                this.Dispose();                                                        
                
                con.Close();
            }
            new StudentNumber().Show();
            MessageBox.Show("Vote Submitted");
        }

    }
}
