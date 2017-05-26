using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Gastos
    {
        private string identificacion;
        private string nombre;
        private string t_reparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string T_reparto
        {
            get
            {
                return t_reparto;
            }

            set
            {
                t_reparto = value;
            }
        }
    }
}
