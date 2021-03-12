using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        persona opersona = new persona("1016834930", "Diego", 2002, 20);
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Show();
        }
    }
}
