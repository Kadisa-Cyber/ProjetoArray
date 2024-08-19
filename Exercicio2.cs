using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArray
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        int[] numeros = new int[4];
        int index = 0, total=0;

        private void btnAdd_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(txtNumero.Text) == false)
                {
                if (index < numeros.Length)
                {
                    numeros[index] = int.Parse(txtNumero.Text);
                    index++;

                    if (index == numeros.Length)
                    {
                        btnAdd.Enabled = false;
                    }
                }
                }
                else
                {
                    MessageBox.Show("Digite algum valor!");
                }
                txtNumero.Text = null;
            }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (index != numeros.Length)
            {
                MessageBox.Show("Digite todos os números do vetor!");
            }
            else
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    total += numeros[i];
                }
                txtTotal.Text = total.ToString();
                btnCalcular.Enabled = false;
            }


        }
    }
}
