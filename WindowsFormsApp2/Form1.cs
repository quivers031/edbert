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
namespace WindowsFormsApp2
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = localhost; uid = root; pwd = ; database = premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name , team_id FROM team";
            DataTable dtTeamHomecBox = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHomecBox);
           
            sqlQuery = "SELECT team_name , team_id FROM team";
            DataTable dtTeamAwaycBox = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamAwaycBox);

            comboBoxHomeTeam.DataSource = dtTeamHomecBox;          
            comboBoxAwayTeam.DataSource = dtTeamAwaycBox;
            comboBoxHomeTeam.DisplayMember = "Nama Tim";
            comboBoxAwayTeam.DisplayMember = "Nama Tim";
            comboBoxHomeTeam.ValueMember = "team_name";
            comboBoxAwayTeam.ValueMember = "team_name";
        }

        public string ManagerHome;
        public string CaptainHome;
        public string ManagerAway;
        public string CaptainAway;
        public string StadiumHome;
        public string CapacityHome;
        private void comboBoxHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT team_name FROM team";
                DataTable dtTeam = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                //ManagerHome = "Select manager_name from manager,team where manager_id = '" + comboBoxHomeTeam.SelectedValue.ToString() + "'";
                //StadiumHome = "Select home_stadium from team where team_name = '" + comboBoxHomeTeam.SelectedText.ToString() + "'";

                sqlQuery = "Select manager_name from manager m, team t where t.manager_id = m.manager_id AND t.team_name = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeManager = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeManager);

                sqlQuery = "Select home_stadium from team t where t.team_name = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeStadium = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeStadium);

                sqlQuery = "Select capacity from team t where t.team_name = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeStadiumCapacity = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeStadiumCapacity);

                /*
                sqlQuery = "Select player_name from player p, team t where t.captain_id = p.captain_id AND t.team_name = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeCaptain = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeCaptain);*/


                labelNManagerH.Text = dtTeamHomeManager.Rows[0][0].ToString();

                labelStadiumHome.Text = dtTeamHomeStadium.Rows[0][0].ToString();

                labelCapacityStadiumH.Text = dtTeamHomeStadiumCapacity.Rows[0][0].ToString();

                //labelNCaptainH.Text = dtTeamHomeCaptain.Rows[0][0].ToString();
            }
            catch (Exception)
            {

                
            }
            

        }

        private void comboBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name FROM team";
            DataTable dtTeam = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            
            

        }

        
    }
}
