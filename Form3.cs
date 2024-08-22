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
    public partial class FormEjercicio2 : Form
    {
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool yaExiste = false;
            //Compruebo que no hayan espacios en blanco
            if (txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                string nombreCompleto = txtApellido.Text.Trim() + " " + txtNombre.Text.Trim();
                //Compruebo que el nombre completo no exista en la lista
                foreach (string itemNomApe in lbLista.Items)
                {
                    //Verifico que cada item (Nombre y Apellido que se encuentran
                    //en la lista) no sean iguales comparando c/una en mayúscula
                    if (itemNomApe.ToUpper() == nombreCompleto.ToUpper())
                    {
                        yaExiste = true;
                    }
                }

                if (yaExiste)
                {
                    MessageBox.Show("Ya existe esta persona en la lista.");
                    txtNombre.Clear();  //Tmb puede ser txtNombre.Text = "";
                    txtApellido.Clear(); //Lo mismo acá txtApellido.Text = "";
                }
                else
                {
                    lbLista.Items.Add(nombreCompleto);




                    //Al final borrar los campos de nombre y apellido de los TextBoxs
                    txtNombre.Clear();  //Tmb puede ser txtNombre.Text = "";
                    txtApellido.Clear(); //Lo mismo acá txtApellido.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe completar ambos campos.");
                txtNombre.Clear();  //Tmb puede ser txtNombre.Text = "";
                txtApellido.Clear(); //Lo mismo acá txtApellido.Text = "";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Pregunto si el usuario no seleccionó ningún elemento (nombre)
            if (lbLista.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un nombre para borrar.");
            }
            else
            {
                //int indice = lbLista.SelectedIndex;
                //Aca deberia borrar el item seleccionado
                lbLista.Items.Remove(lbLista.SelectedItem);
            }
        }
    }
}

