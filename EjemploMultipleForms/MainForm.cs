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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void but_form1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            this.Hide();
        }

        private void but_form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void btn_Mensaje_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Este es el mensaje", "Este es el título", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes) { }
            //if()
        }

        private void btn_dialog_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            DialogResult result = formDialog.ShowDialog();

            if(result==DialogResult.OK)
            {
                MessageBox.Show("Presionó OK");
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Presionó Cancelar");
            }

        }
    }
}
