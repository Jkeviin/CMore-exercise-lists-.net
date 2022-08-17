using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas;

namespace App_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Variables 
        private List<float> notas = new List<float>();
        int i = 0;

        private void btnagregar_Click(object sender, EventArgs e)
        {
            float nota;
         
            try
            {
                // Capturamos los valores de las cajas de texto.
                nota = float.Parse(txtnotas.Text);

                // Instanciar la logica de negocios
                lib_notas ObjNT = new lib_notas();

                // Enviar los valores a la LN
                ObjNT.SetNota = nota;
                ObjNT.SetCantidad = notas.Count;
                ObjNT.SetNotas = notas.Sum();

                if (ObjNT.ValidacionAgregar())
                {
                    notas.Add(nota);
                    i++;
                    lista_nota.Text += $"NOTA {i}:     {nota}\n\r";
                }
                else
                {
                    MessageBox.Show(ObjNT.GetError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            string nombre;

            try
            {
                // Capturamos los valores de las cajas de text
                nombre = txtnombre.Text;

                // Instanciar la logica de negocios
                lib_notas ObjNT = new lib_notas();

                // Enviar los valores a la LN
                ObjNT.SetCantidad = notas.Count;
                ObjNT.SetNombre = nombre;
                ObjNT.SetCantidad = notas.Count;
                ObjNT.SetNotas = notas.Sum();

                if (ObjNT.Calcular())
                {
                    txtresultado.Text = $"{nombre}, su resultado es: {ObjNT.GetResultado.ToString()}";
                }
                else
                {
                    MessageBox.Show(ObjNT.GetError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtnotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
