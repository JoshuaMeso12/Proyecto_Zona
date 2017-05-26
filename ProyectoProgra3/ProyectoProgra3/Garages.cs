using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Garages: Propiedades
    {
        private string abiercerr;
        private string bodega;

        public string Abiercerr
        {
            get
            {
                return abiercerr;
            }

            set
            {
                abiercerr = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}
