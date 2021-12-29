using Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA1220
{
    public partial class addurl : Form
    {
        private static string linkadd1;
        
        public static string Linkadd1 { get => linkadd1; set => linkadd1 = value; }
        internal static List<truckclass> Beolvasottlista { get => beolvasottlista; set => beolvasottlista = value; }

        private static List<truckclass> beolvasottlista = new List<truckclass>();
        public addurl()
        {
            InitializeComponent();
        }

        private void megseurl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keszaddurl_Click(object sender, EventArgs e)
        {
            string beolvasott = label1.Text; 
            beolvasottlista.Add(beolvasott);
        }

        internal static void ActiveForm(addurl addurl)
        {
            throw new NotImplementedException();
        }
    }
}
