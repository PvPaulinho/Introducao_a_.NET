using System.Drawing.Imaging;

namespace SimplePaint
{
    public partial class FormPrincipal : Form
    {
        private bool flagPintar = false; //Para definir quando se deve pintar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; //Para controlar quando se quer apagar
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;

        public FormPrincipal()
        {
            InitializeComponent();

            //As propriedades abaixo s� fazem efeito quando o bot�o est� com a propriedade FlatStyle como Flat
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod; //Altera a cor do bot�o quando passar o mause por cima do bot�o
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;

            comboBoxEspessuraDaCaneta.Text = "10"; //Texto ir� aparecer inicialmente na comboBox
            for (int i = 2; i < 100; i += 2) //Ir� preencher a comboBox de 2 a 100 de 2 em 2
            {
                comboBoxEspessuraDaCaneta.Items.Add(i);
            }

            comboBoxEspessuraDaCaneta.MaxDropDownItems = 10; //Define o numero de itens que ir� aparecer na comboBox
            comboBoxEspessuraDaCaneta.IntegralHeight = false; //Necess�rio para que seja poss�vel definir a quantidade de itens da comboBox

            graphicsPainelPintura = panelPintura.CreateGraphics(); //Permite o desenho sobre o controle
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text); //Converte o texto da comboBox espessura para o tipo float
            corBorracha = panelPintura.BackColor; //Especifica a cor padr�o da borracha como a cor do painel

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a podermos desenhar nela
            graphicsImagemASalvar.Clear(panelPintura.BackColor); //Para preencher a imagem inicial com a cor padr�o do painel
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Ocorre quando se muda o indice da comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        /*
         Handler do evento de click do bot�o de cor da caneta
        � disparado quando o bot�o � clicado
        Serve para manipularmos oque ocorre quando clicamos no bot�o
         */
        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog(); //ColorDialog � uma caixa de sele��o de cores
            var corEscolhida = colorDialog.ShowDialog(); //Exibe na forma modal - Aplica��o fica parada at� fechar a janela
            if (corEscolhida == DialogResult.OK) //Verifica se o usu�rio clicou em ok.
            {
                buttonCorCaneta.BackColor = colorDialog.Color; //Altera a cor do bot�o para a cor selecionada
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar)
            {
                if (!flagApagar)
                {
                    // Desenhamos uma elipse de cor e espessura definida pelo usu�rio, nas coordenadas do ponteiro do mouse
                    graphicsPainelPintura
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    // Desenhando na imagem para salvar
                    graphicsImagemASalvar
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    // Desenhamos uma elipse de cor e espessura definida pelo usu�rio, nas coordenadas do ponteiro do mouse
                    graphicsPainelPintura
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // Transformamos uma vari�vel tipo float em tipo inteiro
                    // Desenhando na imagem para salvar
                    graphicsImagemASalvar
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // Transformamos uma vari�vel tipo float em tipo inteiro
                }

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // A MessageBox representa uma janela para exibi��o de mensagens ao usu�rio
            if (MessageBox.Show("Tem certeza disso? Todo o desenho ser� apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White); // Limpa todo o desenho e preenche novamente o fundo do painel de branco
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a podermos desenhar nela
                graphicsImagemASalvar.Clear(panelPintura.BackColor); // Preenchemos a imagem com a cor do fundo do painel
            }
        }

        // SelectedIndexChanged ocorre quando � feita uma escolha de item pelo usu�rio na comboBox
        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) //Executar� caso clique com o bot�o direito do mouse em borracha
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; //Seleciona a cor da borracha de acordo com a escolha do usu�rio
                }
            }
            else
            {
                if (!flagApagar) //o operador ! ir� virar o valor da flagApagar ao contr�rio, quando selecionar mudar� de true para false ou de false para true
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha; //A cor do bot�o ser� a mesma da cor da borracha
                }
                else
                {
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.Black; //A cor do bot�o voltar� ao padr�o
                }
            }
        }

        private void panelPintura_Resize(object sender, EventArgs e) //Evento disparado sempre que o painel � redimencionado
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); //Atualiza a refer�ncia do objeto graphics do painel
            var imgTemp = new Bitmap(panelPintura.Width, panelPintura.Height); //Criando uma imagem tempor�ria
            var graphicsImgTemp = Graphics.FromImage(imgTemp);
            graphicsImgTemp.DrawImage(imagemASalvar, 0, 0);
            imagemASalvar = imgTemp;
            graphicsImagemASalvar = graphicsImgTemp;
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); // Janela para salvar arquivos
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg"; // Atribuindo formatos de imagem para o usu�rio escolher
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Definindo a extens�o da imagem que iremos salvar
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }
    }
}
