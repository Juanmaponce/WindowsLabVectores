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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            string[] estudiantes = IngresarAlumnos();
            for (int i = 0; i < estudiantes.Length; i++)
            {
                int[] notasEstudiante = IngresarNotas(estudiantes[i]);
                MostrarNotas(estudiantes[i], notasEstudiante);
                MostrarNotaMayor(estudiantes[i], notasEstudiante);
                int promedio = CalcularPromedio(notasEstudiante);
                MostrarMensajeNota(estudiantes[i], promedio);
            }
        }

        #region metodos

        public string[] IngresarAlumnos()
        {
            string[] alumnos = new string[4];
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = Interaction.InputBox("Ingrese el nombre del alumno");
            }
            return alumnos;
        }

        public int[] IngresarNotas(string alumno)
        {
            int[] notas = new int[3]; 
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese Nota:" + alumno));
            }
            return notas;
        }

        public void MostrarNotas(string alumno, int[] notas)
        {
            MessageBox.Show(alumno + ": " + string.Join(", ", notas));
        }

        public int CalcularPromedio(int[] notas)
        {
            int sumaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                sumaNotas += notas[i];
            }
            int promedio = sumaNotas/notas.Length;
            return promedio;
        }

        public void MostrarNotaMayor(string alumno, int[] notas)
        {
            int mayor = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                }
            }
            MessageBox.Show("La mayor nota de " + alumno + " es: " + mayor.ToString());
        }

        public void MostrarMensajeNota (string alumno, int promedio)
        {
            if (promedio < 4)
            {
                MessageBox.Show("Promedio:"+ promedio + "\nDebe ir al recuperatorio");
            }
            else if (promedio <= 7)
            {
                MessageBox.Show("Promedio:" + promedio + "\nBien");
            }
            else if (promedio > 7)
            {
                MessageBox.Show("Promedio:" + promedio + "\nMuy Bien");
            }
        }
        #endregion
    }
}
