using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CineTech
{
    public partial class TelaAssistir : Form
    {
        public TelaAssistir()
        {
            InitializeComponent();
        }
        private void TelaAssistir(object sender, EventArgs e)
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

        private void mtxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DateTime dataNascimento;
            if (!DateTime.TryParseExact(mtxData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
            {
                MessageBox.Show("Por favor, insira uma data de nascimento válida no formato dd/MM/yyyy.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxData.Focus();
                return;
            }

            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 1)
            {
                MessageBox.Show("A data de nascimento deve indicar que o usuário tem pelo menos 1 ano de idade.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxData.Focus();
            }
        }

        private void btnAssistirAgora_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Por favor, insira uma data de nascimento válida no formato dd/MM/yyyy.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            mtxData.Focus();
            return;
        }

        DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                Image--;
            }

            if (idade< 1)
            {
                MessageBox.Show("A data de nascimento deve indicar que o usuário tem pelo menos 1 ano de idade.", "Data de Nascimento Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxData.Focus();
                return;
            }

                // Se todos os campos são válidos, prossiga com a lógica do seu sistema
            MessageBox.Show($"Nome: {textBoxNome.Text}\nData de Nascimento: {mtxData.Text}", "Informações Validadas", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }

}

