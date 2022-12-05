using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Senior.Modelo
{
    class Usuarios
    {
		private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string puesto;
        private int edad;
        private string correo;
        private string fechaNacimiento;

        public Usuarios()
        {
            this.nombres = "";
            this.apellidoPaterno = "";
            this.apellidoMaterno = "";
            this.puesto = "";
            this.edad = 0;
            this.correo = "";
            this.fechaNacimiento = "";


        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
