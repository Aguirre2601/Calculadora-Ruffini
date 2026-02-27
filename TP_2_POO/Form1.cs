using System;
using System.Collections.Generic; 
using System.Windows.Forms;
using CapaNegocio;
using CapaCalculos;

namespace TP_2_POO
{
    public partial class RuffiniCal : Form
    {
        public RuffiniCal()
        {
            InitializeComponent();
            txtPolinomio.Select();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorDeError.Clear();
            Validar valida = new Validar();
            valida.PoliValida = Convert.ToString(txtPolinomio.Text);
            List<Error> Errores = valida.ValidarAlgo();
            if (Errores.Count > 0)
            {
                txtPolinomio.SelectAll();
                foreach (Error er in Errores)
                ProveedorDeError.SetError(this.Controls[er.Control], er.Mensaje);
            }
            else
            {
                ProveedorDeError.Clear();
                Calucladora();
            }
        }
        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)  c.Text = "";
            }
            ProveedorDeError.Clear();
        }
         private void txtPolinomio_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V)|| (e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.Shift && e.KeyCode == Keys.V))
            {
                e.Handled = true;  
            }
        }      
        
        private void Calucladora()
        {
            CalculaRaiz caculador = new CalculaRaiz();
            caculador.CalculaElPolinomio = Convert.ToString(txtPolinomio.Text);
            List <double> listaRaices = caculador.Calculador();
            if (listaRaices.Count>0)
            {
                for (int r=0; r <listaRaices.Count;r++)
                {
                    TextBox txt = (TextBox)this.Controls["txtRaiz" + (r + 1)];
                    txt.Text = listaRaices[r].ToString();
                }
            }
            else
            {
                ProveedorDeError.SetError(txtPolinomio, "Esta Funcion no posee raices.");
            }
        }

       


    }
}
