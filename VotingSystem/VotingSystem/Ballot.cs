using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Ballot : Form
    {
        //for moving form
        private Point MouseDownLocation;

        //References
        private MySqlConnection con = new MySqlConnection("datasource=172.16.122.52; port=3306;username=root;password=; database=voting_system;");
        private string program;
        private string student_num;
        private string[] party1_name = new string[11];
        private Int32[] party1_id = new Int32[11];
        private Int32[] party2_id = new Int32[11];
        private string[] party1_nick = new string[11];
        private string[] party2_name = new string[11];
        private string[] party2_nick = new string[11];
        private Int32 clickCounter = 0;
        private Int32[] chosenId = {0,0,0,0,0,0,0 };
        private String[] chosenName = new String[7];
        private Int32 num = 0;

        public Ballot()
        {
            InitializeComponent();

            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tbl_candidates";
                MySqlDataReader sqlDataReader = null;
                sqlDataReader = cmd.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    if(sqlDataReader.GetString("Candidate_party") == "Partylist1")
                    {
                        switch (sqlDataReader.GetString("candidate_position"))
                        {
                            case "President":
                                party1_name[0] = sqlDataReader.GetString("candidate_name");
                                party1_nick[0] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[0] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Academic Affairs":
                                party1_name[1] = sqlDataReader.GetString("candidate_name");
                                party1_nick[1] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[1] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Internal Affairs":
                                party1_name[2] = sqlDataReader.GetString("candidate_name");
                                party1_nick[2] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[2] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For External Affairs":
                                party1_name[3] = sqlDataReader.GetString("candidate_name");
                                party1_nick[3] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[3] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Operations":
                                party1_name[4] = sqlDataReader.GetString("candidate_name");
                                party1_nick[4] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[4] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Finance":
                                party1_name[5] = sqlDataReader.GetString("candidate_name");
                                party1_nick[5] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[5] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "ICT Representative":
                                party1_name[6] = sqlDataReader.GetString("candidate_name");
                                party1_nick[6] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[6] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Engineering Representative":
                                party1_name[7] = sqlDataReader.GetString("candidate_name");
                                party1_nick[7] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[7] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Accountancy, Business & Management Representative":
                                party1_name[8] = sqlDataReader.GetString("candidate_name");
                                party1_nick[8] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[8] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Tourism & Hospitality Management Representative":
                                party1_name[9] = sqlDataReader.GetString("candidate_name");
                                party1_nick[9] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[9] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Arts & Sciences Representative":
                                party1_name[10] = sqlDataReader.GetString("candidate_name");
                                party1_nick[10] = sqlDataReader.GetString("candidate_nickname");
                                party1_id[10] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                        }
                    }
                    else if(sqlDataReader.GetString("Candidate_party") == "Partylist2")
                    {
                        switch (sqlDataReader.GetString("candidate_position"))
                        {
                            case "President":
                                party2_name[0] = sqlDataReader.GetString("candidate_name");
                                party2_nick[0] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[0] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Academic Affairs":
                                party2_name[1] = sqlDataReader.GetString("candidate_name");
                                party2_nick[1] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[1] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Internal Affairs":
                                party2_name[2] = sqlDataReader.GetString("candidate_name");
                                party2_nick[2] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[2] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For External Affairs":
                                party2_name[3] = sqlDataReader.GetString("candidate_name");
                                party2_nick[3] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[3] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Operations":
                                party2_name[4] = sqlDataReader.GetString("candidate_name");
                                party2_nick[4] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[4] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Vice President For Finance":
                                party2_name[5] = sqlDataReader.GetString("candidate_name");
                                party2_nick[5] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[5] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "ICT Representative":
                                party2_name[6] = sqlDataReader.GetString("candidate_name");
                                party2_nick[6] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[6] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Engineering Representative":
                                party2_name[7] = sqlDataReader.GetString("candidate_name");
                                party2_nick[7] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[7] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Accountancy, Business & Management Representative":
                                party2_name[8] = sqlDataReader.GetString("candidate_name");
                                party2_nick[8] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[8] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Tourism & Hospitality Management Representative":
                                party2_name[9] = sqlDataReader.GetString("candidate_name");
                                party2_nick[9] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[9] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                            case "Arts & Sciences Representative":
                                party2_name[10] = sqlDataReader.GetString("candidate_name");
                                party2_nick[10] = sqlDataReader.GetString("candidate_nickname");
                                party2_id[10] = sqlDataReader.GetInt32("Candidate_id");
                                break;
                        }
                    }
                }
                sqlDataReader.Close();
                con.Close();

                setCandidateName(clickCounter, clickCounter);

                getAchievement(party1_id[0], party2_id[0]);
                getPlatform(party1_id[0], party2_id[0]);

            }
            catch(Exception name)
            {
                MessageBox.Show(name.ToString());
            }
        }

        void setCandidateName(Int32 id1, Int32 id2)
        {
            txt_candidate_name1.Text = party1_name[id1];
            txt_candidate_name2.Text = party2_name[id2];
            txt_candidate_nickname1.Text = party1_name[id1];
            txt_candidate_nickname2.Text = party2_name[id2];
        }

        void getAchievement(Int32 id1, Int32 id2)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tbl_candidate_achievement where candidate_id = " + id1.ToString();
                MySqlDataReader sqlDataReader = null;
                sqlDataReader = cmd.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    listview_achievement1.Items.Add(sqlDataReader.GetString("Achievement_title"));
                }

                sqlDataReader.Close();

                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select * from tbl_candidate_achievement where candidate_id = " + id2.ToString();
                MySqlDataReader sqlDataReader1 = null;
                sqlDataReader1 = cmd1.ExecuteReader();

                while (sqlDataReader1.Read())
                {
                    listview_achievement2.Items.Add(sqlDataReader1.GetString("Achievement_title"));
                }

                sqlDataReader1.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void getPlatform(Int32 id1, Int32 id2)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tbl_candidate_platform where candidate_id = " + id1.ToString();
                MySqlDataReader sqlDataReader = null;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    listView_Platform1.Items.Add(sqlDataReader.GetString("platform"));
                }

                sqlDataReader.Close();

                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select * from tbl_candidate_platform where candidate_id = " + id2.ToString();
                MySqlDataReader sqlDataReader1 = null;
                sqlDataReader1 = cmd1.ExecuteReader();

                while (sqlDataReader1.Read())
                {
                    listView_Platform2.Items.Add(sqlDataReader1.GetString("platform"));
                }

                sqlDataReader1.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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

        private void President_Enter(object sender, EventArgs e)
        {
            buttonActive(President);
        }

        private void President_Leave(object sender, EventArgs e)
        {
            buttonInactive(President);
        }

        private void Ballot_Load(object sender, EventArgs e)
        {
           
            
            President.PerformClick();
        }


        void buttonActive(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.FromArgb(46, 64, 83);
        }

        void buttonInactive(Button button)
        {
            button.BackColor = Color.FromArgb(46, 64, 83);
            button.ForeColor = Color.FromArgb(208, 211, 212);
        }

        private void button5_Enter(object sender, EventArgs e)
        {
            buttonActive(vp_acad);
        }

        private void vp_acad_Leave(object sender, EventArgs e)
        {
            buttonInactive(vp_acad);
        }

        private void vp_external_Enter(object sender, EventArgs e)
        {
            buttonActive(vp_external);

        }

        private void vp_external_Leave(object sender, EventArgs e)
        {
            buttonInactive(vp_external);
        }

        private void vp_operation_Enter(object sender, EventArgs e)
        {
            buttonActive(vp_operation);
        }

        private void vp_operation_Leave(object sender, EventArgs e)
        {
            buttonInactive(vp_operation);
        }

        private void vp_finance_Enter(object sender, EventArgs e)
        {
            buttonActive(vp_finance);
        }

        private void vp_finance_Leave(object sender, EventArgs e)
        {
            buttonInactive(vp_finance);
        }

        private void dept_representation_Enter(object sender, EventArgs e)
        {
            buttonActive(dept_representation);
        }

        private void dept_representation_Leave(object sender, EventArgs e)
        {
            buttonInactive(dept_representation);
        }

        private void vp_internal_Enter(object sender, EventArgs e)
        {
            buttonActive(vp_internal);
        }

        private void vp_internal_Leave(object sender, EventArgs e)
        {
            buttonInactive(vp_internal);
        }

        Control lastFocused;

        void setUnfocus(object sen)
        {

            buttonInactive(President);
           
            lastFocused = sen as Control;
            
            lastFocused.Focus();
        }

        private void President_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            buttonActive(President);
            clearListView();
            clickCounter = 0;
            setCandidateName(0, 0);
            getAchievement(party1_id[0], party2_id[0]);
            getPlatform(party1_id[0], party2_id[0]);
        }

        private void vp_acad_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 1;
            setCandidateName(1, 1);
            getAchievement(party1_id[1], party2_id[1]);
            getPlatform(party1_id[1], party2_id[1]);
        }

        private void vp_internal_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 2;
            setCandidateName(2, 2);
            getAchievement(party1_id[2], party2_id[2]);
            getPlatform(party1_id[2], party2_id[2]);
        }

        private void vp_external_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 3;
            setCandidateName(3, 3);
            getAchievement(party1_id[3], party2_id[3]);
            getPlatform(party1_id[3], party2_id[3]);
        }

        private void vp_operation_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 4;
            setCandidateName(4, 4);
            getAchievement(party1_id[4], party2_id[4]);
            getPlatform(party1_id[4], party2_id[4]);
        }

        private void vp_finance_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 5;
            setCandidateName(5, 5);
            getAchievement(party1_id[5], party2_id[5]);
            getPlatform(party1_id[5], party2_id[5]);
        }

        void clearListView()
        {
            listview_achievement1.Items.Clear();
            listview_achievement2.Items.Clear();
            listView_Platform1.Items.Clear();
            listView_Platform2.Items.Clear();
        }

        private void dept_representation_Click(object sender, EventArgs e)
        {
            setUnfocus(sender);
            clearListView();
            clickCounter = 6;
            String[] programs = {"BSIT", "BSCS", "BACOMM", "BMMA", "BSA", "BSMA", "BCPE", "BSHM", "BSTM"};

            if (program.Equals(programs[0]) || program.Equals(programs[1]))
            {
                dept_representation.Text = "ICT Representative";
                num = 6;
            }
            else if (program.Equals(programs[2]) || program.Equals(programs[3]))
            {
                dept_representation.Text = "Arts & Sciences Representative";
                num =10;
            }
            else if (program.Equals(programs[4]) || program.Equals(programs[5]))
            {
                dept_representation.Text = "Accountancy, Business & Management Representative";
                num = 8;
            }
            else if (program.Equals(programs[6]))
            {
                dept_representation.Text = "Engineering Representative";
                num = 7;
            }
            else if (program.Equals(programs[7]) || program.Equals(programs[8]))
            {
                dept_representation.Text = "Tourism & Hospitality Management Representative";
                num = 9;
            }
            setCandidateName(num, num);

            getAchievement(party1_id[num], party2_id[num]);
            getPlatform(party1_id[num], party2_id[num]);
        }

        public void checkProgram(TextBox tb)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_students where student_number = '" + tb.Text + "'" ;
            MySqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                program = sqlDataReader["program"].ToString();
                student_num = sqlDataReader["student_number"].ToString();              
            }
            sqlDataReader.Close();
            con.Close();
        }

        private void vote_party1_btn_Click(object sender, EventArgs e)
        {
            switch (clickCounter)
            {
                case 0:
                    chosenId[0] = party1_id[0];
                    chosenName[0] = party1_name[0];
                    buttonActive(vp_acad); 
                    buttonInactive(President);
                    vp_acad.PerformClick();
                    break;
                case 1:
                    chosenId[1] = party1_id[1];
                    chosenName[1] = party1_name[1];
                    buttonActive(vp_internal); 
                    buttonInactive(vp_acad);
                    vp_internal.PerformClick();
                    break;
                case 2:
                    chosenId[2] = party1_id[2];
                    chosenName[2] = party1_name[2];
                    buttonActive(vp_external); 
                    buttonInactive(vp_internal);
                    vp_external.PerformClick();
                    break;
                case 3:
                    chosenId[3] = party1_id[3];
                    chosenName[3] = party1_name[3];
                    buttonActive(vp_operation); 
                    buttonInactive(vp_external);
                    vp_operation.PerformClick();
                    break;
                case 4:
                    chosenId[4] = party1_id[4];
                    chosenName[4] = party1_name[4];
                    buttonActive(vp_finance); 
                    buttonInactive(vp_operation);
                    vp_finance.PerformClick();
                    break;
                case 5:
                    chosenId[5] = party1_id[5];
                    chosenName[5] = party1_name[5];
                    buttonActive(dept_representation); 
                    buttonInactive(vp_finance);
                    dept_representation.PerformClick();
                    break;
                case 6:
                    buttonInactive(dept_representation);
                    chosenId[6] = party1_id[num];
                    chosenName[6] = party1_name[num];
                    confirm();
                    break;
            }
        }
        
        private void vote_party2_btn_Click(object sender, EventArgs e)
        {
            switch (clickCounter)
            {
                case 0:
                    chosenId[0] = party2_id[0];
                    chosenName[0] = party2_name[0];
                    buttonActive(vp_acad); 
                    buttonInactive(President);
                    vp_acad.PerformClick();
                    break;
                case 1:
                    chosenId[1] = party2_id[1];
                    chosenName[1] = party2_name[1];
                    buttonActive(vp_internal); 
                    buttonInactive(vp_acad);
                    vp_internal.PerformClick();
                    break;
                case 2:
                    chosenId[2] = party2_id[2];
                    chosenName[2] = party2_name[2];
                    buttonActive(vp_external); 
                    buttonInactive(vp_internal);
                    vp_external.PerformClick();
                    break;
                case 3:
                    chosenId[3] = party2_id[3];
                    chosenName[3] = party2_name[3];
                    buttonActive(vp_operation); 
                    buttonInactive(vp_external);
                    vp_operation.PerformClick();
                    break;
                case 4:
                    chosenId[4] = party2_id[4];
                    chosenName[4] = party2_name[4];
                    buttonActive(vp_finance); 
                    buttonInactive(vp_operation);
                    vp_finance.PerformClick();
                    break;
                case 5:
                    chosenId[5] = party2_id[5];
                    chosenName[5] = party2_name[5];
                    buttonActive(President); 
                    buttonInactive(dept_representation);
                    dept_representation.PerformClick();
                    break;
                case 6:
                    buttonInactive(dept_representation);
                    chosenId[6] = party2_id[num];
                    chosenName[6] = party2_name[num];
                    confirm();
                    break;
            }

        }

        void setClicked(Button button)
        {
            button.PerformClick();
            button.BackColor = Color.White;
            button.ForeColor = Color.FromArgb(46, 64, 83);
        }

        void setUnclicked(Button button)
        {
            button.BackColor = Color.FromArgb(46, 64, 83);
            button.ForeColor = Color.FromArgb(208, 211, 212);
        }

        void confirm()
        {
            try
            {
                if (chosenId[0] != 0 && chosenId[1] != 0 && chosenId[2] != 0 && chosenId[3] != 0 && chosenId[4] != 0 && chosenId[5] != 0 && chosenId[6] != 0)
                {
           
                    //for transferring value in another class 
                    theGetter.getCandidatePres = chosenName[0];
                    theGetter.getAcademic = chosenName[1];
                    theGetter.getCandidateInternal = chosenName[2];
                    theGetter.getCandidateExternal = chosenName[3];
                    theGetter.getOperation = chosenName[4];
                    theGetter.getFinance = chosenName[5];
                    //--------------for representative
                    theGetter.getDepartment = dept_representation.Text;
                    theGetter.getRepresentative = chosenName[6];

                    theGetter.getId = chosenId;
                    theGetter.getStudentNumber = student_num;
                    this.Hide();
                    new Confirmation().Show();
                }
                else
                {
                    MessageBox.Show("Please vote for every position");
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

        private void label2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
