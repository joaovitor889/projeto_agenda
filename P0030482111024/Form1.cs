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

namespace P0030482111024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[4, 4];
            string auxiliar;
            double[] total = new double[4];
            double result =0;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    auxiliar = Interaction.InputBox("Digite o valor recebido da semana "+(j+1)+" do mês "+(i+1), "Entrada de dados");
                    if (!Double.TryParse(auxiliar, out matriz[i, j]))
                    {
                        MessageBox.Show("Valor invalido!!!");
                        j--;
                    }
                    else
                    {
                        lstboxResultado.Items.Add("Mês " + (i + 1) + "semana " + (j + 1) + ":" + matriz[i, j].ToString("C") + "\n");
                        total[i] += matriz[i, j];
                    }
                }
                lstboxResultado.Items.Add("Total mês " + (i + 1) + ":" + total[i].ToString("C") + "\n");
                lstboxResultado.Items.Add("----------------------------------- \n");
                result += total[i];
            }
            lstboxResultado.Items.Add("O total dos meses foi de : " + result.ToString("C"));

        }
    }
}
