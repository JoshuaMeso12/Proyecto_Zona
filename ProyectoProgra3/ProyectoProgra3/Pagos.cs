using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Pagos
    {
        private string id_pago;
        private string descripcion;
        private int importe;
        private string t_z_reparto;

        public string Id_pago
        {
            get
            {
                return id_pago;
            }

            set
            {
                id_pago = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string T_z_reparto
        {
            get
            {
                return t_z_reparto;
            }

            set
            {
                t_z_reparto = value;
            }
        }
    }
}
