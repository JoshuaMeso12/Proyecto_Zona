using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Propiedades
    {
        private string t_propiedad;
        private string codigo;
        private int m_cuadrados;
        private string nit;
        private string porcentajes;

        public string T_propiedad
        {
            get
            {
                return t_propiedad;
            }

            set
            {
                t_propiedad = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int Cuadrados
        {
            get
            {
                return m_cuadrados;
            }

            set
            {
                m_cuadrados = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Porcentajes
        {
            get
            {
                return porcentajes;
            }

            set
            {
                porcentajes = value;
            }
        }
    }
}
