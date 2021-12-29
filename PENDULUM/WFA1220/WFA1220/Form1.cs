using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Console;
using System.IO;

namespace WFA1220
{
    public partial class Form1 : Form
    {
        private static List<Console.truckclass> zeneszamlista = new List<Console.truckclass>();
        public string ConnectionString { private get; set; }
        internal static List<truckclass> Zeneszamlista { get => zeneszamlista; set => zeneszamlista = value; }
        
        public Form1()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = music;";
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
            
            bekeres();
        }

        private void bekeres()
        {
            StreamReader sr = new StreamReader("pendulum.txt"+"Meghivass");
            string sor = "";
            string kezdes = "[tracks]";
            if (sor == kezdes)
            {
                while (!sr.EndOfStream)
                {
                    sor = sr.ReadLine();
                    truckclass t = new truckclass(sor);
                    zeneszamlista.Add(t);
                }
            }
        }

    

        private void FillCB()
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT DISTINCT album FROM artist;",
                    c).ExecuteReader();
                while (r.Read()) cb1.Items.Add(r[0]);
            }

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var t = new SqlCommand(
                    "SELECT DISTINCT album FROM title;",
                    c).ExecuteReader();
                while (t.Read()) cb2.Items.Add(t[0]);
            }

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var z = new SqlCommand(
                    "SELECT DISTINCT tracks FROM title;",
                    c).ExecuteReader();
                while (z.Read()) { tb1.Items.Add(z[0]); }
            }
        }

        private void FillDGV()
        {

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();



                //5-ös
                string whereAlbum = cb2.SelectedIndex == -1
                    ? "" : $"AND Cim = '{cb2.Text}' ";

                if (cb2.Text == "hold your colour")
                {
                    pictureBox1.InitialImage= Image.FromFile("c:\\hold_your_colour.jpg");
                }
                else if (cb2.Text == "in Silicio")
                {
                    pictureBox1.InitialImage = Image.FromFile("c:\\in _silico.jpg");
                }
                else if (cb2.Text == "immerson")
                {
                    pictureBox1.InitialImage = Image.FromFile("c:\\immersion.jpg");
                }



                var r = new SqlCommand(
                    "SELECT datum " +
                    "FROM Albums ", c).ExecuteReader();

                while (r.Read())
                {
                    richTextBox1.Text = (r[0] + "SELECT COUNT(hossz) FROM Tracks");
                }
                dgv.Rows.Clear();

                c.Open();
                whereAlbum = cb2.SelectedIndex == -1
                    ? "" : $"AND Cim = '{cb2.Text}' ";
                var t = new SqlCommand(
                    "SELECT cime, hossz " +
                    "FROM Tracks;", c).ExecuteReader();
                
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2]);
                }

                for (int i = 0; i < zeneszamlista.Count; i++)
                {
                    string nézdmeg = zeneszamlista[i].Link;

                    if (dgv.Rows[i].Selected)
                    {   String semmi = " ";
                        
                        if (zeneszamlista[i].Link == semmi)
                        {
                            addurlgomb.Enabled = true;

                        }
                        else
                        {
                            linkLabel1.Text = "https://youtube.com/" + zeneszamlista[i].Link;
                        }

                    }
                }
                for (int i = 0; i < zeneszamlista.Count; i++)
                {
                    if (dgv.Rows[i].Selected)
                    {
                        ESgomb.Enabled = true;
                    }
                }
            }
        }

        

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addD ablak = new addD();
            ablak.Show();
        }

        private void addurl_Click(object sender, EventArgs e)
        {
            addurl ablak = new addurl();
            ablak.Show();
        }

        private void ESgomb_Click(object sender, EventArgs e)
        {
            es ablak = new es();
            ablak.Show();
        }
    }


}

