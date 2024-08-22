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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool yaExiste = false;
            
            if (txtNombre.Text.Trim() != "")
            {
                foreach (string nombre in lbLista1.Items)
                {
                    if(nombre.ToUpper() == txtNombre.Text.ToUpper())
                    {
                         yaExiste = true;
                    }
                }

                if (yaExiste)
                {
                    MessageBox.Show("El nombre que desea ingresar ya existe en la lista.");
                }
                else
                {
                    lbLista1.Items.Add(txtNombre.Text.Trim());
                    txtNombre.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún caracter ingresado");
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //Pregunta si hay un item seleccionado
            if (lbLista1.SelectedItem != null)
            {
                //Agrega el Item seleccionado de la lista izquierda a la lista derecha.
                lbLista2.Items.Add(lbLista1.SelectedItem);

                //Elimina el item seleccionado de la lista izquierda.
                lbLista1.Items.Remove(lbLista1.SelectedItem);
            }
            else
            {
                //Si no hay ningun item seleccionado, muestra un cartel
                //que debe seleccionar uno.
                MessageBox.Show("No hay ningún nombre seleccionado. Seleccione uno.");
            }
        }

        private void btnMoverTodo_Click(object sender, EventArgs e)
        {
            //Verifica que la primer lista tenga nombres.
            if (lbLista1.Items.Count > 0)
            {
                //Recorre todos los nombres que existen en la primer lista.
                foreach (string nombres in lbLista1.Items)
                {
                    //Agrega nombre por nombre de la primer lista a la segunda.
                    lbLista2.Items.Add(nombres);
                }

                //Elimina todos los nombres de la primer lista
                lbLista1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres para mover.");
            }
        }
    }
}