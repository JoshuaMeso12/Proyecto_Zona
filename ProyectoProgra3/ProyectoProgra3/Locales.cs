using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Locales : Propiedades
    {
        private string nombrecomercial;
        private string actividad;

        public string Nombrecomercial
        {
            get
            {
                return nombrecomercial;
            }

            set
            {
                nombrecomercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
