namespace EscolaDeNatacao
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblnome = new Label();
            txtnome = new TextBox();
            lblAnoNascimento = new Label();
            txtAnoNascimento = new TextBox();
            btnIdentificar = new Button();
            lblAnoUltimo = new Label();
            txtAnoUltimo = new TextBox();
            lblCategoria = new Label();
            lblCategoriaDoAluno = new Label();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(36, 28);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(43, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "&Nome:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(85, 25);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(380, 23);
            txtnome.TabIndex = 1;
            // 
            // lblAnoNascimento
            // 
            lblAnoNascimento.AutoSize = true;
            lblAnoNascimento.Location = new Point(12, 93);
            lblAnoNascimento.Name = "lblAnoNascimento";
            lblAnoNascimento.Size = new Size(97, 15);
            lblAnoNascimento.TabIndex = 2;
            lblAnoNascimento.Text = "&Ano nascimento:";
            lblAnoNascimento.Click += lblAnoNascimento_Click;
            // 
            // txtAnoNascimento
            // 
            txtAnoNascimento.Location = new Point(122, 93);
            txtAnoNascimento.MaxLength = 4;
            txtAnoNascimento.Name = "txtAnoNascimento";
            txtAnoNascimento.Size = new Size(80, 23);
            txtAnoNascimento.TabIndex = 3;
            txtAnoNascimento.KeyPress += txtAnoNascimento_KeyPress;
            // 
            // btnIdentificar
            // 
            btnIdentificar.Location = new Point(36, 159);
            btnIdentificar.Name = "btnIdentificar";
            btnIdentificar.Size = new Size(150, 30);
            btnIdentificar.TabIndex = 4;
            btnIdentificar.Text = "Identificar Categoria";
            btnIdentificar.UseVisualStyleBackColor = true;
            btnIdentificar.Click += btnIdentificar_Click;
            btnIdentificar.Enter += btnIdentificar_Enter;
            btnIdentificar.KeyDown += btnIdentificar_KeyDown;
            // 
            // lblAnoUltimo
            // 
            lblAnoUltimo.AutoSize = true;
            lblAnoUltimo.Location = new Point(238, 98);
            lblAnoUltimo.Name = "lblAnoUltimo";
            lblAnoUltimo.Size = new Size(130, 15);
            lblAnoUltimo.TabIndex = 5;
            lblAnoUltimo.Text = "An&o último aniversário:";
            // 
            // txtAnoUltimo
            // 
            txtAnoUltimo.Location = new Point(374, 95);
            txtAnoUltimo.MaxLength = 4;
            txtAnoUltimo.Name = "txtAnoUltimo";
            txtAnoUltimo.Size = new Size(80, 23);
            txtAnoUltimo.TabIndex = 6;
            txtAnoUltimo.Enter += txtAnoUltimo_Enter;
            txtAnoUltimo.KeyPress += txtAnoUltimo_KeyPress;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(224, 167);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblCategoriaDoAluno
            // 
            lblCategoriaDoAluno.BackColor = Color.Yellow;
            lblCategoriaDoAluno.BorderStyle = BorderStyle.Fixed3D;
            lblCategoriaDoAluno.Location = new Point(291, 164);
            lblCategoriaDoAluno.Name = "lblCategoriaDoAluno";
            lblCategoriaDoAluno.Size = new Size(175, 25);
            lblCategoriaDoAluno.TabIndex = 9;
            lblCategoriaDoAluno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 234);
            Controls.Add(lblCategoriaDoAluno);
            Controls.Add(lblCategoria);
            Controls.Add(txtAnoUltimo);
            Controls.Add(lblAnoUltimo);
            Controls.Add(btnIdentificar);
            Controls.Add(txtAnoNascimento);
            Controls.Add(lblAnoNascimento);
            Controls.Add(txtnome);
            Controls.Add(lblnome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escola de natação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private TextBox txtnome;
        private Label lblAnoNascimento;
        private TextBox txtAnoNascimento;
        private Button btnIdentificar;
        private Label lblAnoUltimo;
        private TextBox txtAnoUltimo;
        private Label lblCategoria;
        private Label lblCategoriaDoAluno;
    }
}