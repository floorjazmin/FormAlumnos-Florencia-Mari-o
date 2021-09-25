using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class Form1 : Form
    {
        //Creo la lista alumnos
        private List<Alumnos> Alumn = new List<Alumnos>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void botGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {
                Alumn.Add(new Alumnos(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), int.Parse(txtLegajo.Text), txtCarrera.Text, int.Parse(txtAñoInscripcion.Text)));
                MessageBox.Show("El/La Alumno/a se ha registrado correctamente");
                lblDatos.Text = "Usted ha ingresado : " + (Alumn.Count) + " Alumno";
                txtNombre.Clear();
                txtDNI.Clear();
                txtApellido.Clear();
                txtAñoInscripcion.Clear();
                txtCarrera.Clear();
                txtLegajo.Clear();
            }
            else
            {
                MessageBox.Show("Intente nuevamente");
            }
        }

        private void BotEliminar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtApellido.Clear();
            txtAñoInscripcion.Clear();
            txtCarrera.Clear();
            txtLegajo.Clear();
        }

        private void botSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool ValidarDato()
        {
            //valida los campos ingresados por el usuario
            bool datoValido;
            datoValido = true;

            if (txtNombre.Text.Trim() == "")
            {

                MessageBox.Show("El nombre está vacío");
                datoValido = false;
                txtNombre.Focus();

            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El Apellido está vacío");
                txtApellido.Focus();
                datoValido = false;
            }

            try
            {
                Int32.Parse(txtDNI.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato DNI es incorrecto o esta vacio");
                datoValido = false;
            }
                try
                {
                    int.Parse(txtLegajo.Text);


                }
                catch (Exception ex1)
                {
                    MessageBox.Show("El dato Legajo es incorrecto o esta vacio");
                    datoValido = false;
                }
                 if (txtCarrera.Text.Trim() == "")
                 {
                    MessageBox.Show("El Apellido está vacío");
                    txtCarrera.Focus();
                    datoValido = false;
                 }
                try
                {
                    int.Parse(txtAñoInscripcion.Text);


                }
                catch (Exception ex2)
                {
                    MessageBox.Show("El año de inscripcion es incorrecto,debe ingresar 4 numeros o posiblemente el dato esta vacio");
                    datoValido = false;
                    MessageBox.Show("Intente nuevamente");
                }
                return datoValido;
        }

        
    }
}
    
