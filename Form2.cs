using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace Homework_W8
{
    public partial class Form2 : Form
    {
        string connection = "server=localhost;uid=root;pwd=2004-05-31;database=premier_league";
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string away = "";
        string no_away = "";
        string sql;
        DataTable a5 = new DataTable();
        DataTable a6 = new DataTable();
        DataTable a7 = new DataTable();
        DataTable a8 = new DataTable();
        DataTable a9 = new DataTable();
        DataTable a10 = new DataTable();
        string simpen;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM team;";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a5);
            box3.DataSource = a5;
            box3.DisplayMember = "Team Name";
            box3.ValueMember = "Team ID";
        }

        private void box3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            a6 = new DataTable();
            simpen = box3.SelectedValue.ToString();
            sql = "SELECT match_id as `Match ID`, t1.team_name as `Home Team`, t2.team_name as `Away Team` FROM `match` m, team t1, team t2\r\nwhere m.team_home = \"" + simpen + "\" and t1.team_id = m.team_home and t2.team_id = m.team_away;";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a6);

            sql = "SELECT match_id as `Match ID`, t1.team_name as `Home Team`, t2.team_name as `Away Team` FROM `match` m, team t1, team t2\r\nwhere m.team_away = \"" + simpen + "\" and t1.team_id = m.team_home and t2.team_id = m.team_away;";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a6);

            box4.Items.Clear();
            box4.Text = "";
            a6.Columns.Add("judul");
            for (int i = 0; i < a5.Rows.Count; i++)
            {
                box4.Items.Add(a6.Rows[i][1].ToString() + "|VS|" + a6.Rows[i][2].ToString());
                a6.Rows[i][3] = a6.Rows[i][1].ToString() + "|VS|" + a6.Rows[i][2].ToString();
            }
            
        }
        string matchid = "";
        private void box4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            for (int i = 0; i < a5.Rows.Count; i++)
            {
                if (box4.GetItemText(box4.SelectedItem)== a6.Rows[i][3].ToString())
                {
                    matchid = a6.Rows[i][0].ToString();
                    break;
                }
            }
                string []data = box4.GetItemText(box4.SelectedItem).Split('|');
            no_away = data[0];
            away = data[2];

            a7 = new DataTable();
            simpen = box3.SelectedValue.ToString();
            sql = "select p.player_name from team t, player p where t.team_id = p.team_id and t.team_name = '"+ no_away + "';";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a7);
            dgv1.DataSource = a7;

            a8 = new DataTable();
            sql = "select p.player_name from team t, player p where t.team_id = p.team_id and t.team_name = '" + away + "';";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a8);
            dgv2.DataSource = a8;

            a9 = new DataTable();
            sql = "select m.match_date, m.goal_home, m.goal_away, r.referee_name from `match` m, referee r where r.referee_id = m.referee_id and m.match_id = '" + matchid+ "';";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a9);
            label10.Text = a9.Rows[0][1].ToString();
            label11.Text = a9.Rows[0][2].ToString();
            label12.Text = a9.Rows[0][3].ToString();
            label13.Text = a9.Rows[0][0].ToString();
            label3.Text = no_away; label4.Text = away;

            a10 = new DataTable();
            sql = "select t.team_name, p.player_name, if(d.`type`='GO','Goal',if(d.`type`='GW','Own Goal',if(d.`type`='GP','Penalty Goal',if(d.`type`='PM','Penalty Missed',if(d.`type`='CY','Yellow Card','Red Card'))))) as 'Type', d.`minute` from dmatch d, player p, team t where t.team_id = d.team_id and d.player_id = p.player_id and d.match_id = '" + matchid + "';";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a10);
            dgv3.DataSource = a10;
        }
    }
}
