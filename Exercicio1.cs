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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        int[] numeros = new int[4];
        int index = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) == false)
            {
                if (index < numeros.Length)
                {
                    numeros[index] = int.Parse(txtNumero.Text);
                    index++;
                }
                else
                {
                    MessageBox.Show("Limite excedido!");
                    btnAdd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Digite algum valor!");
            }
            txtNumero.Text = null;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            listVetor.Items.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                listVetor.Items.Add(numeros[i]);
            }
        }
    }
}
