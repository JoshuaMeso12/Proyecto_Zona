using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra3
{
    class Pisos : Propiedades
    {
        private string vhvn;
        private int no_habits;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public int No_habits
        {
            get
            {
                return no_habits;
            }

            set
            {
                no_habits = value;
            }
        }
    }
}
