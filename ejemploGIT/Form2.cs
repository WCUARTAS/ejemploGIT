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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label_Edad.Text = "";
        }

        private void btnFormulario1_Click(object sender, EventArgs e)
        {


            Form1 frm = new Form1();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona p = new persona("willian","123",0,1992);
            p.calcular();

            label_Edad.Text = ""+ p.GetEdad();

        }
    }
}
