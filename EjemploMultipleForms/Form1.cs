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
    public partial class Form1 : Form
    {
        Form llamado;
        public Form1(Form llamado_)
        {
            InitializeComponent();
            llamado = llamado_;
        }

        //public Form1()
        //{
        //    InitializeComponent();
        //}
        
        private void but_f1_main_Click(object sender, EventArgs e)
        {
            llamado.Show();
            this.Close();
        }

        private void but_f1_f2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(llamado);
            form2.Show();
            this.Close();
        }
    }
}
