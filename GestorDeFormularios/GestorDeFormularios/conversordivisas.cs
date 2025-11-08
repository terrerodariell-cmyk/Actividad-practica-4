using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeFormularios
{
    public partial class Conversordivisas : Form
    {
        Dictionary<string, double> tasas = new Dictionary<string, double>()
        {
            { "USD", 1.0 },
            { "EUR", 0.92 }, 
            { "GBP", 0.78 }, 
            { "JPY", 157.0 }, 
            { "CNY", 7.2 }, 
            { "DOP", 59.85 },    
        };

        public Conversordivisas()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtmonto.Text);
            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            double tasaOrigen = tasas[origen];
            double tasaDestino = tasas[destino];

            double resultado = (monto / tasaOrigen) * tasaDestino;

            lblResultado.Text = $"{resultado:f2}";
        }

        private void Conversordivisas_Load(object sender, EventArgs e)
        {

        }


        //limpiar los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtmonto.Clear();
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            lblResultado.Text = "0.00";
        }
    }
}
