using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Login_GitHub.Data;

namespace Sistema_de_Login_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.Connection.openConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
