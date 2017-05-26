using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoProgra3
{
    public partial class Form1 : Form
    {
        List<Comunidad> listcomunidad = new List<Comunidad>();
        List<Gastos> listgastos = new List<Gastos>();
        List<Propiedades> listpropiedades = new List<Propiedades>();
        List<Pisos> listpisos = new List<Pisos>();
        List<Locales> listlocales = new List<Locales>();
        List<Garages> listgarages = new List<Garages>();
        List<Propietarios> listpropietarios = new List<Propietarios>();
        List<Pagos> listpagos = new List<Pagos>();
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void guardartodosdatos_Click(object sender, EventArgs e)
        {
            string comunidad = "C:\\Users\\Joshua\\Downloads\\comunidad.txt";
            FileStream stream1 = new FileStream(comunidad, FileMode.Open, FileAccess.Read);
            StreamReader leer1 = new StreamReader(stream1);
            while (leer1.Peek() > -1)
            {
                Comunidad comuntemp = new Comunidad();
                comuntemp.Identificacion = leer1.ReadLine();
                comuntemp.Nombre = leer1.ReadLine();
                comuntemp.Poblacion = leer1.ReadLine();
                listcomunidad.Add(comuntemp);
            }
            leer1.Close();

            string gastos = "C:\\Users\\Joshua\\Downloads\\gastos.txt";
            FileStream stream2 = new FileStream(gastos, FileMode.Open, FileAccess.Read);
            StreamReader leer2 = new StreamReader(stream2);
            while (leer2.Peek() > -1)
            {
                Gastos gastemp = new Gastos();
                gastemp.Identificacion = leer2.ReadLine();
                gastemp.Nombre = leer2.ReadLine();
                gastemp.T_reparto = leer2.ReadLine();
                listgastos.Add(gastemp);
            }
            leer2.Close();

            string propiedades = "C:\\Users\\Joshua\\Downloads\\comunidad.txt";
            FileStream stream3 = new FileStream(propiedades, FileMode.Open, FileAccess.Read);
            StreamReader leer3 = new StreamReader(stream3);
            while (leer3.Peek() > -1)
            {
                Propiedades propiedtemp = new Propiedades();
                List<string> proporcen = new List<string>(); 
                propiedtemp.T_propiedad = leer3.ReadLine();
                propiedtemp.Codigo = leer3.ReadLine();
                propiedtemp.Cuadrados = Convert.ToInt32(leer3.ReadLine());
                propiedtemp.Nit = leer3.ReadLine();
                propiedtemp.Porcentajes = leer3.ReadLine();
                listpropiedades.Add(propiedtemp);
            }
            leer3.Close();

            while (listpropiedades.Count > j)
            {
                if (listpropiedades[j].T_propiedad == "P")
                {
                    Pisos pisostemp = new Pisos();
                    pisostemp.Codigo = listpropiedades[j].Codigo;
                    pisostemp.Cuadrados = listpropiedades[j].Cuadrados;
                    pisostemp.Nit = listpropiedades[j].Nit;
                    string datpisos = listpropiedades[j].Porcentajes;
                    string[] dividida = datpisos.Split(',');
                    foreach(string dp in dividida)
                    {
                        if (dp.Trim() != ";")
                        {
                            pisostemp.Vhvn = dividida[j];
                            pisostemp.No_habits = Convert.ToInt32(dividida[j]);
                        }
                    }
                    listpisos.Add(pisostemp);
                }
                if (listpropiedades[j].T_propiedad == "L")
                {
                    Locales localtemp = new Locales();
                    localtemp.Codigo = listpropiedades[j].Codigo;
                    localtemp.Cuadrados = listpropiedades[j].Cuadrados;
                    localtemp.Nit = listpropiedades[j].Nit;
                    string datlocs = listpropiedades[j].Porcentajes;
                    string[] dividida = datlocs.Split(',');
                    foreach(string dl in dividida)
                    {
                        if(dl.Trim() != ";")
                        {
                            localtemp.Nombrecomercial = dividida[j];
                            localtemp.Actividad = dividida[j];
                        }
                    }
                    listlocales.Add(localtemp);
                }
                if (listpropiedades[j].T_propiedad == "G")
                {
                    Garages garatemp = new Garages();
                    garatemp.Codigo = listpropiedades[j].Codigo;
                    garatemp.Cuadrados = listpropiedades[j].Cuadrados;
                    garatemp.Nit = listpropiedades[j].Nit;
                    string datgar = listpropiedades[j].Porcentajes;
                    string[] dividida = datgar.Split(',');
                    foreach (string dg in dividida)
                    {
                        if(dg.Trim() != ";")
                        {
                            garatemp.Abiercerr = dividida[j];
                            garatemp.Bodega = dividida[j];
                        }
                    }
                    listgarages.Add(garatemp);
                }
                j++;
            }

            string propietarios = "C:\\Users\\Joshua\\Downloads\\propietarios.txt";
            FileStream stream4 = new FileStream(propietarios, FileMode.Open, FileAccess.Read);
            StreamReader leer4 = new StreamReader(stream4);
            while (leer4.Peek() > -1)
            {
                Propietarios propietemp = new Propietarios();
                propietemp.Nombre = leer4.ReadLine();
                propietemp.Nit = leer4.ReadLine();
                propietemp.Email = leer4.ReadLine();
                listpropietarios.Add(propietemp);
            }
            leer4.Close();

            string pagos = "C:\\Users\\Joshua\\Downloads\\pagos.txt";
            FileStream stream5 = new FileStream(pagos, FileMode.Open, FileAccess.Read);
            StreamReader leer5 = new StreamReader(stream5);
            while (leer5.Peek() > -1)
            {
                Pagos pagostemp = new Pagos();
                pagostemp.Id_pago = leer5.ReadLine();
                pagostemp.Descripcion = leer5.ReadLine();
                pagostemp.Importe = Convert.ToInt32(leer5.ReadLine());
                pagostemp.T_z_reparto = leer5.ReadLine();
                listpagos.Add(pagostemp);
            }
            leer5.Close();
        }
    }
}
