using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Senior.Datos;
using CRUD_Senior.Modelo;

namespace CRUD_Senior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Usuarios em = new Usuarios();
            em.Nombres = txtNombre.Text;
            em.ApellidoPaterno = txtApellidopaterno.Text;
            em.ApellidoMaterno = txtApellidoMaterno.Text;
            em.Puesto = txtPuesto.Text;
            em.Edad = Convert.ToInt32(txtNumerotelefono.Text);
            em.Correo = txtCorreo.Text;
            em.FechaNacimiento = dateNacimiento.Value.Year+"-"+ dateNacimiento.Value.Month+"-"+ dateNacimiento.Value.Day;

            if(UsuariosDB.guardarUsuario(em))
            {
                MessageBox.Show("Todo gud");
            }
            else
            {
                MessageBox.Show("Todo mal");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar su correo");

            }
            else
            {
                Usuarios em = UsuariosDB.consultar(txtCorreo.Text);
                if(em == null)
                {
                    MessageBox.Show("No existe el empleado con ese correo");
                }
                else
                {
                    txtNombre.Text = em.Nombres;
                    txtApellidopaterno.Text = em.ApellidoPaterno;
                    txtApellidoMaterno.Text = em.ApellidoMaterno;
                    txtPuesto.Text = em.Puesto;
                    txtNumerotelefono.Text = em.Edad.ToString();
                    dateNacimiento.Text = em.FechaNacimiento;

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuarios em = new Usuarios();
            em.Nombres = txtNombre.Text;
            em.ApellidoPaterno = txtApellidopaterno.Text;
            em.ApellidoMaterno = txtApellidoMaterno.Text;
            em.Puesto = txtPuesto.Text;
            em.Edad = Convert.ToInt32(txtNumerotelefono.Text);
            em.Correo = txtCorreo.Text;
            em.FechaNacimiento = dateNacimiento.Value.Year + "-" + dateNacimiento.Value.Month + "-" + dateNacimiento.Value.Day;

            if (UsuariosDB.actualizar(em))
            {
                MessageBox.Show("Se actualizo gud");
            }
            else
            {
                MessageBox.Show("Todo mal x2");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (UsuariosDB.borrar(txtCorreo.Text))
            {
                MessageBox.Show("Se borro nice");
            }
            else
            {
                MessageBox.Show("Todo mal x3");
            }
        }
    }
}
