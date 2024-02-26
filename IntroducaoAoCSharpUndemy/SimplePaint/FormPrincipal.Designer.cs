namespace SimplePaint
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
            Personalizar = new GroupBox();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            buttonBorracha = new Button();
            label2 = new Label();
            comboBoxEspessuraDaCaneta = new ComboBox();
            label1 = new Label();
            buttonCorCaneta = new Button();
            panelPintura = new Panel();
            Personalizar.SuspendLayout();
            SuspendLayout();
            // 
            // Personalizar
            // 
            Personalizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Personalizar.Controls.Add(buttonSalvar);
            Personalizar.Controls.Add(buttonLimpar);
            Personalizar.Controls.Add(buttonBorracha);
            Personalizar.Controls.Add(label2);
            Personalizar.Controls.Add(comboBoxEspessuraDaCaneta);
            Personalizar.Controls.Add(label1);
            Personalizar.Controls.Add(buttonCorCaneta);
            Personalizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Personalizar.ForeColor = Color.White;
            Personalizar.Location = new Point(12, 12);
            Personalizar.Name = "Personalizar";
            Personalizar.Size = new Size(776, 92);
            Personalizar.TabIndex = 0;
            Personalizar.TabStop = false;
            Personalizar.Text = "Personalizar";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Black;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(665, 34);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(89, 28);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click_1;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Black;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(561, 34);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(89, 28);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonBorracha
            // 
            buttonBorracha.BackColor = Color.Black;
            buttonBorracha.FlatStyle = FlatStyle.Flat;
            buttonBorracha.Location = new Point(461, 34);
            buttonBorracha.Name = "buttonBorracha";
            buttonBorracha.Size = new Size(83, 28);
            buttonBorracha.TabIndex = 4;
            buttonBorracha.Text = "Borracha";
            buttonBorracha.UseVisualStyleBackColor = false;
            buttonBorracha.MouseDown += buttonBorracha_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 42);
            label2.Name = "label2";
            label2.Size = new Size(156, 18);
            label2.TabIndex = 3;
            label2.Text = "Espessura da caneta";
            // 
            // comboBoxEspessuraDaCaneta
            // 
            comboBoxEspessuraDaCaneta.FormattingEnabled = true;
            comboBoxEspessuraDaCaneta.Location = new Point(372, 36);
            comboBoxEspessuraDaCaneta.Name = "comboBoxEspessuraDaCaneta";
            comboBoxEspessuraDaCaneta.Size = new Size(69, 26);
            comboBoxEspessuraDaCaneta.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 1;
            label1.Text = "Cor da caneta";
            // 
            // buttonCorCaneta
            // 
            buttonCorCaneta.BackColor = Color.Blue;
            buttonCorCaneta.FlatStyle = FlatStyle.Flat;
            buttonCorCaneta.Location = new Point(119, 37);
            buttonCorCaneta.Name = "buttonCorCaneta";
            buttonCorCaneta.Size = new Size(75, 23);
            buttonCorCaneta.TabIndex = 0;
            buttonCorCaneta.UseVisualStyleBackColor = false;
            buttonCorCaneta.Click += buttonCorCaneta_Click;
            // 
            // panelPintura
            // 
            panelPintura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPintura.BackColor = Color.White;
            panelPintura.Location = new Point(12, 110);
            panelPintura.Name = "panelPintura";
            panelPintura.Size = new Size(776, 328);
            panelPintura.TabIndex = 1;
            panelPintura.MouseDown += panelPintura_MouseDown;
            panelPintura.MouseMove += panelPintura_MouseMove;
            panelPintura.MouseUp += panelPintura_MouseUp;
            panelPintura.Resize += panelPintura_Resize;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPintura);
            Controls.Add(Personalizar);
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = "Simple Paint";
            Personalizar.ResumeLayout(false);
            Personalizar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Personalizar;
        private ComboBox comboBoxEspessuraDaCaneta;
        private Label label1;
        private Button buttonCorCaneta;
        private Label label2;
        private Button buttonSalvar;
        private Button buttonLimpar;
        private Button buttonBorracha;
        private Panel panelPintura;
    }
}
