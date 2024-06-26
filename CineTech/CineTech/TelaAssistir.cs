using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTech
{
    public partial class TelaAssistir : Form
    {
        public TelaAssistir()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Lista de filmes
            List<string> filmes = new List<string>
            {
                "O Poderoso Chefão",
                "Pulp Fiction",
                "A Origem",
                "Matrix",
                "Clube da Luta",
                "Interestelar"
            };

            // Adiciona os filmes na ComboBox
            cbxFilme.DataSource = filmes;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            // Verifica se algum filme foi selecionado
            if (cbxFilme.SelectedIndex == -1)
            {
                // Nenhum filme foi selecionado, mostra uma mensagem de erro
                MessageBox.Show("Por favor, selecione um filme.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Filme selecionado, continue com a lógica do seu sistema
                string filmeSelecionado = cbxFilme.SelectedItem.ToString();
                MessageBox.Show($"Você selecionou o filme: {filmeSelecionado}", "Filme Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePickerNascimento_Leave(object sender, EventArgs e)
        {
            DateTime dataNascimento = dateTimePickerNascimento.Value;
            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 1)
            {
                MessageBox.Show("A data de nascimento deve indicar que o usuário tem pelo menos 1 ano de idade.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerNascimento.Focus();
            }
        }
    }
}
