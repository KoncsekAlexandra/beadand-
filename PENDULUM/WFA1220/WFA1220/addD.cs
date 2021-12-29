using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA1220
{
    public partial class addD : Form
    {
        private static string meghivass;
        public addD()
        {
            InitializeComponent();
        }

        public static string Meghivass { get => meghivass; set => meghivass = value; }

        private void megse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        { string filebekeres = "  ";
            if (filebekeres == bekeres.Text)
            {
                meghivass = bekeres.Text;
            }
        }
    }
}
