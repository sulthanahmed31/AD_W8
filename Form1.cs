using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Homework_W8
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=2004-05-31;database=premier_league";
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string sql;
        DataTable a1 = new DataTable();
        DataTable a2 = new DataTable();
        DataTable a3 = new DataTable();
        DataTable a4 = new DataTable();
        string simpan;
        string namatim;
        string tim_pilih;
        List<Label> lbl = new List<Label> ();
        int rc = 0; int yc = 0; int gs = 0; int go = 0; int ps = 0; int pm = 0;
        List<Int32> total = new List<Int32>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new MySqlConnection(connection);
            SqlConnection.Open();
            sql = "SELECT team_name as `Team Name`, team_id as `Team ID` FROM team;";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a1);
            box1.DataSource = a1;
            box1.DisplayMember = "Team Name";
            box1.ValueMember = "Team ID";

            lbl.Add(label4); lbl.Add(label5); lbl.Add(label6); lbl.Add(label7); lbl.Add(label8); lbl.Add(label9); lbl.Add(label10); lbl.Add(label11); lbl.Add(label12); lbl.Add(label15); lbl.Add(label16);
        }
        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true; label2.Visible = true; box1.Visible = true; box2.Visible = true;
            label2.Text = "Choose Player";
        }

        private void matchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 second = new Form2();
            second.Show();
        }

        private void box1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            a2 = new DataTable();
            simpan = box1.SelectedValue.ToString();
            sql = "SELECT player_name as `Player Name`, player_id as `Player ID` FROM player p\r\nwhere p.team_id = \"" + simpan + "\";";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a2);
            box2.DataSource = a2;
            box2.DisplayMember = "Player Name";
            box2.ValueMember = "Player ID";
        }
        int count = 0;
        private void box2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            simpan = box2.SelectedValue.ToString();
            a3 = new DataTable();
            namatim = box2.GetItemText(box2.SelectedItem).ToString(); tim_pilih = box1.GetItemText(box1.SelectedItem).ToString();
            sql = "SELECT player_name as `Player Name`, team_name as `Team Name`, playing_pos as `Position`, nation as `Nationality`, team_number as `Squad Number` FROM player p, team t, nationality n\nwhere p.player_name = \"" + namatim + "\" and t.team_name = \"" + tim_pilih + "\" and p.nationality_id = n.nationality_id; ";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a3);
            for (int i = 0; i < 5; i++)
            {
                lbl[i].Text = a3.Rows[0][i].ToString();
            }

            a4 = new DataTable();
            sql = "SELECT `type` as `Cards` FROM dmatch d\r\nwhere d.player_id = \"" + simpan + "\";";
            SqlCommand = new MySqlCommand(sql, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(a4);
            rc = 0; yc = 0; go = 0; gs = 0; ps = 0; pm = 0;
            for (int i = 0; i < a4.Rows.Count; i++)
            {
                if (a4.Rows[i][0].ToString() == "CR")
                {
                    rc++;
                }
                if (a4.Rows[i][0].ToString() == "CY")
                {
                    yc++;
                }
                if (a4.Rows[i][0].ToString() == "GW")
                {
                    go++;
                }
                if (a4.Rows[i][0].ToString() == "G0")
                {
                    gs++;
                }
                if (a4.Rows[i][0].ToString() == "GP")
                {
                    ps++;
                }
                if (a4.Rows[i][0].ToString() == "PM")
                {
                    pm++;
                }
            }
            total.Add(yc); total.Add(rc); total.Add(gs); total.Add(go); total.Add(ps); total.Add(pm);
            for (int i = 5; i <= 10; i++)
            {
                lbl[i].Text = total[count].ToString();
                count++;
            }
            panel1.Visible = true;
        }
    }
}
