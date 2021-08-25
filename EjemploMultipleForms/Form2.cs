using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMultipleForms
{
    public partial class Form2 : Form
    {
        Form llamado;
        public Form2(Form llamado_)
        {
            InitializeComponent();
            llamado = llamado_;
        }
       

        private void but_f2_main_Click(object sender, EventArgs e)
        {
            llamado.Show();
            this.Close();
        }

        private void but_f2_f1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(llamado);
            form1.Show();
            this.Close();
        }
    }
}
