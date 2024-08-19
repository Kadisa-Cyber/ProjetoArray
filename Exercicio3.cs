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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        int coluna=0, linha=0;
        int[,] numeros = new int[3,3];

        private void btnExibir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<=2; i++)
            {
                for(int j = 0; j<=2; j++)
                {
                    listMatriz.Items.Add($"Matriz posição {i} {j} = {numeros[i,j]}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (linha <= 2)
            {
                if (coluna <= 2)
                {
                    numeros[linha, coluna] = int.Parse(txtNumero.Text);
                    coluna++;

                    if (coluna > 2)
                    {
                        linha++;
                        coluna = 0;
                        if (linha > 2)
                        {
                            btnAdd.Enabled = false;
                            txtNumero.Enabled = false;
                        }
                    }
                }

                txtNumero.Text = null;
            }

        }
    }
}
