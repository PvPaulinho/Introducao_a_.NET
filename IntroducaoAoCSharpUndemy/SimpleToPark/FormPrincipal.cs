using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Importando componentes do VisualBasic

namespace SimpleToPark
{
    public partial class FormPrincipal : Form
    {
        private DataTable bancoDeDados; //Usado para armazenar dados em formato de tabela
        private GerenciadorArrecadacao gerenciador; // classe que contém a lógica de cálculo do valor a ser pago pelo cliente


        public FormPrincipal()
        {
            InitializeComponent();

            bancoDeDados = new DataTable("Estacionamento"); //Criando tabela estacionamento
            bancoDeDados.Columns.Add("Placa", typeof(string)); //Adicionamos uma coluna chamada placa do tipo string
            bancoDeDados.Columns.Add("Entrada", typeof(string)); //Adicionamos uma coluna chamada Entrada do tipo string

            dataGridViewCarrosEstacionados.DataSource = bancoDeDados; //Atrelando o dataGridView ao dataTable

            gerenciador = new GerenciadorArrecadacao // Inicializamos o gerenciador
            {
                ValorHora = 10,
                Arrecadado = 0
            };

            labelValorHora.Text = $"Valor da hora: R$ {gerenciador.ValorHora.ToString("0.00")}";

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do veículo:", "Entrada de veículo"); //Exibe janela para usuário digitar a placa do carro usando o Visual Basic
            if (!string.IsNullOrEmpty(placa)) //Verifica se a placa está como vazia ou não, para saber se o usuário clicou em ok ou cancelar
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString() }); //Cadastrando veículo
                dataGridViewCarrosEstacionados.Rows[dataGridViewCarrosEstacionados.Rows.Count - 1].MinimumHeight = 30; //Modificamos a altura da ultima linha
            }
        }

        private void buttonConfigurar_Click(object sender, EventArgs e)
        {
            var valorDaHora = Interaction.InputBox("Digite o valor da hora:", "Valor da hora");
            if (!string.IsNullOrEmpty(valorDaHora))
            {
                gerenciador.ValorHora = float.Parse(valorDaHora);
                labelValorHora.Text = $"Valor da hora: R$ {gerenciador.ValorHora.ToString("0.00")}";
            }
        }

        // Esse método será chamado quando o usuário clicar duas vezes sobre uma célula
        // da primeira coluna, ou seja, quando ele der duplo clique sobre a placa do 
        // veículo.
        private void dataGridViewCarrosEstacionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1) // Verifica se clicou na linha da coluna de placas (ColumnIndex = 0) e em uma linha válida
            {
                // Recupera a hora de entrada e a placa do veículo
                var entrada = DateTime.Parse(bancoDeDados.Rows[e.RowIndex].ItemArray[1].ToString()); // Recupera a data/hora de entrada
                var placa = bancoDeDados.Rows[e.RowIndex].ItemArray[0].ToString(); // Recupera a placa do veículo

                var arrecadado = gerenciador.CalcularEstadiaCliente(entrada); // Calcula o valor que o cliente deverá pagar

                // Exibe mensagem
                if (MessageBox
                    .Show(this, $"Deseja encerrar o ticket de {placa}? Valor: R$ {arrecadado.ToString("0.00")}", "Encerrar Ticket", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Remove do banco de dados
                    bancoDeDados.Rows.RemoveAt(e.RowIndex);
                    // Arrecada o valor
                    gerenciador.Arrecadado = arrecadado;
                    // Atualiza o valor na tela
                    labelValorArrecadado.Text = $"Total Arrecadado: R$ {gerenciador.Arrecadado.ToString("0.00")}";
                }
            }
        }
    }
}
