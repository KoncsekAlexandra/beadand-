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
using System.Windows.Input;
using Console;

namespace WFA1220
{
    public partial class es : Form
    {
        Button gomb = new Button();
        Button gomb1 = new Button();
        public string ConnectionString { private get; set; }
        public es()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = music;";
            InitializeComponent();
            SqlCommand cmd = new SqlCommand( "UPDATE Tracks SET cime = (titlebe.Text), hossz= (lengbe.Text)  ");
                
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biztosan el akarod menteni?"); 
                gomb.Text = "Igen";
            gomb.Location = new Point(112, 50);
            gomb.Click += new EventHandler(Button_Click);
            Controls.Add(gomb);
               gomb1.Text = "nem";
            gomb1.Location = new Point(112, 100);
            gomb1.Click += new EventHandler(Button1_Click);
            Controls.Add(gomb1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tracks SET cime = (titlebe.Text), hossz= (lengbe.Text)  ");

        }
    }
}
