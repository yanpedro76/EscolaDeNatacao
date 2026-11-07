using System;
using System.Windows.Forms;

namespace EscolaDeNatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAnoUltimo_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("digite primeiro o ano de nascimento com 4 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoNascimento.Focus();
            }
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            lblCategoriaDoAluno.Text = "";

            if (string.IsNullOrWhiteSpace(txtAnoNascimento.Text) || string.IsNullOrWhiteSpace(txtAnoUltimo.Text))
            {
                MessageBox.Show("digite o ano de nascimento e o ano do último aniversário.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAnoNascimento.Text.Trim(), out int anoNascimento) || !int.TryParse(txtAnoUltimo.Text.Trim(), out int anoUltimo))
            {
                MessageBox.Show("os anos devem ser números inteiros válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (anoUltimo <= anoNascimento)
            {
                MessageBox.Show("o ano do último aniversário deve ser maior do que o ano de nascimento.", "Ano inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnoUltimo.Focus();
                return;
            }

            int idade = anoUltimo - anoNascimento;
            string categoria;

            if (idade >= 5 && idade <= 7)
                categoria = "INFANTIL A";
            else if (idade >= 8 && idade <= 10)
                categoria = "INFANTIL B";
            else if (idade >= 11 && idade <= 13)
                categoria = "JUVENIL A";
            else if (idade >= 14 && idade <= 17)
                categoria = "JUVENIL B";
            else if (idade >= 18)
                categoria = "ADULTO";
            else
                categoria = "Idade inferior a 5 anos";

            lblCategoriaDoAluno.Text = categoria;
        }

        private void txtAnoNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtAnoUltimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnIdentificar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnIdentificar_Enter(object sender, EventArgs e)
        {

        }

        private void lblAnoNascimento_Click(object sender, EventArgs e)
        {

        }
    }
}