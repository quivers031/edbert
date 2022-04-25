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
            //"server = 139.255.11.84; uid = student; pwd = isbmantap ; database = premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name as 'Nama Tim', team_id FROM team";
            DataTable dtTeamHomecBox = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHomecBox);
           
            sqlQuery = "SELECT team_name as 'Nama Tim' , team_id FROM team";
            DataTable dtTeamAwaycBox = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamAwaycBox);

            comboBoxHomeTeam.DataSource = dtTeamHomecBox;          
            comboBoxAwayTeam.DataSource = dtTeamAwaycBox;
            comboBoxHomeTeam.DisplayMember = "Nama Tim";
            comboBoxAwayTeam.DisplayMember = "Nama Tim";
            comboBoxHomeTeam.ValueMember = "team_id";
            comboBoxAwayTeam.ValueMember = "team_id";
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

                sqlQuery = "Select manager_name from manager m, team t where t.manager_id = m.manager_id AND t.team_id = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeManager = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeManager);

                //sqlQuery = "Select home_stadium from team t where t.team_name = '" + comboBoxHomeTeam.SelectedValue + "'";
                sqlQuery = "Select CONCAT(home_stadium,' , ',city) from team t where t.team_id = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeStadium = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeStadium);

                sqlQuery = "Select capacity from team t where t.team_id = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeStadiumCapacity = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeStadiumCapacity);

                
                sqlQuery = "Select player_name from player p, team t where t.captain_id = p.player_id AND t.team_id = '" + comboBoxHomeTeam.SelectedValue + "'";
                DataTable dtTeamHomeCaptain = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamHomeCaptain);

                


                labelNManagerH.Text = dtTeamHomeManager.Rows[0][0].ToString();

                labelStadiumHome.Text = dtTeamHomeStadium.Rows[0][0].ToString();

                labelCapacityStadiumH.Text = dtTeamHomeStadiumCapacity.Rows[0][0].ToString();

                labelNCaptainH.Text = dtTeamHomeCaptain.Rows[0][0].ToString();
            }
            catch (Exception)
            {

                
            }
            

        }

        private void comboBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "Select manager_name from manager m, team t where t.manager_id = m.manager_id AND t.team_id = '" + comboBoxAwayTeam.SelectedValue + "'";
                DataTable dtTeamAwayManager = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamAwayManager);

                sqlQuery = "Select player_name from player p, team t where t.captain_id = p.player_id AND t.team_id = '" + comboBoxAwayTeam.SelectedValue + "'";
                DataTable dtTeamAwayCaptain = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamAwayCaptain);

                labelNManagerA.Text = dtTeamAwayManager.Rows[0][0].ToString();
                labelNCaptainA.Text = dtTeamAwayCaptain.Rows[0][0].ToString();
                
            }
            catch (Exception)
            {

                
            }
            
            
            

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            try
            { 

                sqlQuery = "SELECT date_format(m.match_date, '%d %M %Y') FROM `match` m, dmatch d " +
                    "where m.match_id=d.match_id and m.team_home ='" + comboBoxHomeTeam.SelectedValue + "' and m.team_away='" + comboBoxAwayTeam.SelectedValue + "';";
                DataTable dtTanggal = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTanggal);
                
                sqlQuery = "SELECT concat(m.goal_home, ' - ', m.goal_away) FROM `match` m, dmatch d " +
                    "where m.match_id = d.match_id and m.team_home ='" + comboBoxHomeTeam.SelectedValue + "' and m.team_away='" + comboBoxAwayTeam.SelectedValue + "';";
                DataTable dtSkor = new DataTable();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtSkor);

                labelIsiTanggal.Text = dtTanggal.Rows[0][0].ToString();

                labelIsiSkor.Text = dtSkor.Rows[0][0].ToString();

               
               DataTable dtMatch = new DataTable();
               sqlQuery = "SELECT if (d.`type` = 'GW', if(d.team_id != m.team_home, p.player_name,''), if (p.team_id = m.team_home, p.player_name, '' )) as 'Player Name 1', if (d.`type` = 'GW', if (d.team_id != m.team_home, 'OWN GOAL' ,''), if (p.team_id = m.team_home, if (d.`type` = 'CY', 'YELLOW CARD', if (d.`type` = 'CR', 'RED CARD',  if (d.`type` = 'GO', 'GOAL',  if (d.`type` = 'GP', 'GOAL PENALTY', if (d.`type` = 'GW', 'OWN GOAL', if (d.`type` = 'PM', 'PENALTY MISS', p.player_name)))))), '')) as 'Tipe 1', if (d.`type` = 'GW', if (d.team_id != m.team_away, p.player_name,''), if (p.team_id = m.team_away, p.player_name, '' )) as 'Player Name 2',if (d.`type` = 'GW', if (d.team_id != m.team_away, 'OWN GOAL' ,''), if (p.team_id = m.team_away, if (d.`type` = 'CY', 'YELLOW CARD',if (d.`type` = 'CR', 'RED CARD', if (d.`type` = 'GO', 'GOAL', if (d.`type` = 'GP', 'GOAL PENALTY',  if (d.`type` = 'GW', 'OWN GOAL',if (d.`type` = 'PM', 'PENALTY MISS', p.player_name)))))), '')) as 'Tipe 2' FROM dmatch d, `match` m, player p WHERE d.match_id = m.match_id AND p.player_id = d.player_id AND m.team_home ='" + comboBoxHomeTeam.SelectedValue + "' and m.team_away='" + comboBoxAwayTeam.SelectedValue + "';";
               sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
               sqlAdapter = new MySqlDataAdapter(sqlCommand);
               sqlAdapter.Fill(dtMatch);
               dgvPertandingan.DataSource = dtMatch;

            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
