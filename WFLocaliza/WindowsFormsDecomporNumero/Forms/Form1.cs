using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WindowsFormsDecomporNumero.Metodos;

namespace WindowsFormsDecomporNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void bntDecompor_Click(object sender, EventArgs e)
        {
            string divisoresTexto = "", divisoresPrimoTexto = "";

            divisores.Text = "";
            divisoresPrimo.Text = "";
            try
            {
                if (numero.Text == "")
                {
                    MessageBox.Show("Dígite um número para fazer a decomposição !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DecompoNumeroRequest.DecomporNumero(Convert.ToInt64(numero.Text), ref divisoresTexto, ref divisoresPrimoTexto);
                }
                divisores.Text = divisoresTexto;
                divisoresPrimo.Text = divisoresPrimoTexto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
