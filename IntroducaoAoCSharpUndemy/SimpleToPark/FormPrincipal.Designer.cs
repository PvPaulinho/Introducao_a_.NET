namespace SimpleToPark
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelValorArrecadado = new Label();
            dataGridViewCarrosEstacionados = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCadastrar = new Button();
            buttonConfigurar = new Button();
            labelValorHora = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrosEstacionados).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8651676F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.1348343F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(890, 333);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelValorArrecadado, 0, 1);
            tableLayoutPanel2.Controls.Add(dataGridViewCarrosEstacionados, 0, 0);
            tableLayoutPanel2.Location = new Point(161, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 84.09786F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9021406F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(726, 327);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelValorArrecadado
            // 
            labelValorArrecadado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelValorArrecadado.AutoSize = true;
            labelValorArrecadado.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorArrecadado.Location = new Point(523, 308);
            labelValorArrecadado.Name = "labelValorArrecadado";
            labelValorArrecadado.Size = new Size(200, 19);
            labelValorArrecadado.TabIndex = 0;
            labelValorArrecadado.Text = "Valor Arrecadado R$ 0,00";
            // 
            // dataGridViewCarrosEstacionados
            // 
            dataGridViewCarrosEstacionados.AllowUserToAddRows = false;
            dataGridViewCarrosEstacionados.AllowUserToDeleteRows = false;
            dataGridViewCarrosEstacionados.AllowUserToResizeColumns = false;
            dataGridViewCarrosEstacionados.AllowUserToResizeRows = false;
            dataGridViewCarrosEstacionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCarrosEstacionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarrosEstacionados.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCarrosEstacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrosEstacionados.Location = new Point(3, 3);
            dataGridViewCarrosEstacionados.Name = "dataGridViewCarrosEstacionados";
            dataGridViewCarrosEstacionados.ReadOnly = true;
            dataGridViewCarrosEstacionados.RowHeadersVisible = false;
            dataGridViewCarrosEstacionados.Size = new Size(720, 269);
            dataGridViewCarrosEstacionados.TabIndex = 1;
            dataGridViewCarrosEstacionados.CellDoubleClick += dataGridViewCarrosEstacionados_CellDoubleClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(buttonCadastrar, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonConfigurar, 0, 2);
            tableLayoutPanel3.Controls.Add(labelValorHora, 0, 1);
            tableLayoutPanel3.Location = new Point(12, 15);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9602451F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 62.07951F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6544342F));
            tableLayoutPanel3.Size = new Size(155, 327);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastrar.BackColor = Color.Silver;
            buttonCadastrar.Location = new Point(3, 3);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(149, 56);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonConfigurar
            // 
            buttonConfigurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonConfigurar.BackColor = Color.Silver;
            buttonConfigurar.Location = new Point(3, 268);
            buttonConfigurar.Name = "buttonConfigurar";
            buttonConfigurar.Size = new Size(149, 56);
            buttonConfigurar.TabIndex = 1;
            buttonConfigurar.Text = "Configurar";
            buttonConfigurar.UseVisualStyleBackColor = false;
            buttonConfigurar.Click += buttonConfigurar_Click;
            // 
            // labelValorHora
            // 
            labelValorHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelValorHora.AutoSize = true;
            labelValorHora.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorHora.Location = new Point(3, 227);
            labelValorHora.Name = "labelValorHora";
            labelValorHora.Size = new Size(141, 38);
            labelValorHora.TabIndex = 2;
            labelValorHora.Text = "Valor da Hora R$ 0,00";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(914, 357);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = "Simple To Park";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrosEstacionados).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelValorArrecadado;
        private DataGridView dataGridViewCarrosEstacionados;
        private Button buttonCadastrar;
        private Button buttonConfigurar;
        private Label labelValorHora;
    }
}
