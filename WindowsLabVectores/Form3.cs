using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace WindowsLabVectores
{
    public partial class Form3 : Form
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSueldos_Click(object sender, EventArgs e)
        {
            Cargar();
            CalcularSumaSueldos();
            ImprimirTotalPagado();


        }

        #region metodos
        public void Cargar()
        {
            empleados = new String[4];
            sueldos = new int[4, 3];
            for (int f = 0; f < empleados.Length; f++)
            {
                empleados[f] = Interaction.InputBox("Ingrese el nombre del operario " + (f + 1) + ": ");
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    string linea;
                    linea = Interaction.InputBox("Ingrese sueldo " + (c + 1) + ": ");
                    sueldos[f, c] = int.Parse(linea);
                }
            }
        }

        public void CalcularSumaSueldos()
        {
            sueldostot = new int[4];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
                sueldostot[f] = suma;
            }
        }

        public void ImprimirTotalPagado()
        {
            MessageBox.Show("Total de sueldos pagados por Operario.");
            for (int f = 0; f < sueldostot.Length; f++)
            {
                MessageBox.Show(empleados[f] + " - " + sueldostot[f]);
            }
        }

        public void EmpleadoMayorSueldo()
        {
            int may = sueldostot[0];
            string nom = empleados[0];
            for (int f = 0; f < sueldostot.Length; f++)
            {
                if (sueldostot[f] > may)
                {
                    may = sueldostot[f];
                    nom = empleados[f];
                }
            }
            MessageBox.Show("El operario con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
        }





        #endregion
    }
}
