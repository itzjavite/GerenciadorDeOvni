﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            // Adicionar os planetas no comboBox:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            // Verificar se o número de tripulantes está vazio:
            if(txbTripulantes.Text == "")
            {
                MessageBox.Show("Informe o máximo de tripulantes!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbAbduzidos.Text == "")
            {
                MessageBox.Show("Informe a capacidade do compartimento de abduzidos!", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbPlanetas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o planeta de origem!", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Variaveis para receber os valores dos txbs:
                int maxTripulantes = int.Parse(txbTripulantes.Text);
                int maxAbduzidos = int.Parse(txbAbduzidos.Text);
                string planetaOrigem = cmbPlanetas.Text;

                // Instanciar o OVNI:
                BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes,maxAbduzidos,planetaOrigem);

                // Instanciar a janela "gerenciador" para conseguir chama-la:
                Gerenciador gerenciador = new Gerenciador(ovni);

                // Esconder a janela atual:
                Hide();

                // Abrir a janela do gerenciador:
                gerenciador.ShowDialog();

                // Mostrar novamente a janela atual após a aterior fechar:
                Show();

            }
        }
    }
}
