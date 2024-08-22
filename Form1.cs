using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo9
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormEjercicio1 formEjercicio1 = new FormEjercicio1();
            formEjercicio1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormEjercicio2 formEjercicio2 = new FormEjercicio2();
            formEjercicio2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormEjercicio3 formEjercicio3 = new FormEjercicio3();
            formEjercicio3.Show();
        }
    }
}
