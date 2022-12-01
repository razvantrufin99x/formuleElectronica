using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formuleElectronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OhmLawDC ohmDC = new OhmLawDC();

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = ohmDC.I(10, 25).ToString();

        }
    }
}
