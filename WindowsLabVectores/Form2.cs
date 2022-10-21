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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int[] prices = IngresarPrecios();
            int preciosSumados = SumarPrecios(prices);

            MessageBox.Show("La sumatoria de todos los precios es: " + preciosSumados);
        }

        #region mis metodos
        
        public int[] IngresarPrecios()
        {
            int[] precios = new int[8];
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i] = Convert.ToInt32(Interaction.InputBox("Ingrese Precio:"));
            }
            return precios;
        }

        public int SumarPrecios(int[] precios)
        {
            int sumaPrecios = 0;
            for (int i = 0; i < precios.Length; i++)
            {
                sumaPrecios += precios[i];
            }
            return sumaPrecios;
        }

        #endregion
    }
}
