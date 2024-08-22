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
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string textoLabel;
            //Pregunto si la cantidad (Count) de elementos chequeados
            //es mayor a cero.
            if (chkOficio.CheckedItems.Count > 0)
            {

                textoLabel = "Usted seleccionó los siguientes elementos: " + "\r\n";
                textoLabel += "Sexo: " + (string)(rdbFemenino.Checked ? "Mujer" : "Hombre") + "\r\n";
                textoLabel += "Estado Civil: " + (string)(rdbSoltero.Checked ? "Soltero" : "Casado") + "\r\n";
                textoLabel += "Ocupación: " + "\r\n";

                for (int i = 0; i < chkOficio.CheckedItems.Count; i++)
                {
                    textoLabel += "     - " + chkOficio.CheckedItems[i].ToString() + "\r\n";
                }

                lblInfo.Text = textoLabel;

                lblInfo.Visible = true;
            }
            else
            {
                //Mostrar un mensaje que diga que seleccione un oficio
                MessageBox.Show("Seleccione un oficio.");
            }

        }
    }
}
