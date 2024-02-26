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

            //As propriedades abaixo só fazem efeito quando o botão está com a propriedade FlatStyle como Flat
            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod; //Altera a cor do botão quando passar o mause por cima do botão
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;

            comboBoxEspessuraDaCaneta.Text = "10"; //Texto irá aparecer inicialmente na comboBox
            for (int i = 2; i < 100; i += 2) //Irá preencher a comboBox de 2 a 100 de 2 em 2
            {
                comboBoxEspessuraDaCaneta.Items.Add(i);
            }

            comboBoxEspessuraDaCaneta.MaxDropDownItems = 10; //Define o numero de itens que irá aparecer na comboBox
            comboBoxEspessuraDaCaneta.IntegralHeight = false; //Necessário para que seja possível definir a quantidade de itens da comboBox

            graphicsPainelPintura = panelPintura.CreateGraphics(); //Permite o desenho sobre o controle
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text); //Converte o texto da comboBox espessura para o tipo float
            corBorracha = panelPintura.BackColor; //Especifica a cor padrão da borracha como a cor do painel

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a podermos desenhar nela
            graphicsImagemASalvar.Clear(panelPintura.BackColor); //Para preencher a imagem inicial com a cor padrão do painel
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
         Handler do evento de click do botão de cor da caneta
        É disparado quando o botão é clicado
        Serve para manipularmos oque ocorre quando clicamos no botão
         */
        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog(); //ColorDialog é uma caixa de seleção de cores
            var corEscolhida = colorDialog.ShowDialog(); //Exibe na forma modal - Aplicação fica parada até fechar a janela
            if (corEscolhida == DialogResult.OK) //Verifica se o usuário clicou em ok.
            {
                buttonCorCaneta.BackColor = colorDialog.Color; //Altera a cor do botão para a cor selecionada
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
                    // Desenhamos uma elipse de cor e espessura definida pelo usuário, nas coordenadas do ponteiro do mouse
                    graphicsPainelPintura
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    // Desenhando na imagem para salvar
                    graphicsImagemASalvar
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    // Desenhamos uma elipse de cor e espessura definida pelo usuário, nas coordenadas do ponteiro do mouse
                    graphicsPainelPintura
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // Transformamos uma variável tipo float em tipo inteiro
                    // Desenhando na imagem para salvar
                    graphicsImagemASalvar
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta)); // Transformamos uma variável tipo float em tipo inteiro
                }

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // A MessageBox representa uma janela para exibição de mensagens ao usuário
            if (MessageBox.Show("Tem certeza disso? Todo o desenho será apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White); // Limpa todo o desenho e preenche novamente o fundo do painel de branco
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); // imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a podermos desenhar nela
                graphicsImagemASalvar.Clear(panelPintura.BackColor); // Preenchemos a imagem com a cor do fundo do painel
            }
        }

        // SelectedIndexChanged ocorre quando é feita uma escolha de item pelo usuário na comboBox
        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right) //Executará caso clique com o botão direito do mouse em borracha
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; //Seleciona a cor da borracha de acordo com a escolha do usuário
                }
            }
            else
            {
                if (!flagApagar) //o operador ! irá virar o valor da flagApagar ao contrário, quando selecionar mudará de true para false ou de false para true
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha; //A cor do botão será a mesma da cor da borracha
                }
                else
                {
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.Black; //A cor do botão voltará ao padrão
                }
            }
        }

        private void panelPintura_Resize(object sender, EventArgs e) //Evento disparado sempre que o painel é redimencionado
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); //Atualiza a referência do objeto graphics do painel
            var imgTemp = new Bitmap(panelPintura.Width, panelPintura.Height); //Criando uma imagem temporária
            var graphicsImgTemp = Graphics.FromImage(imgTemp);
            graphicsImgTemp.DrawImage(imagemASalvar, 0, 0);
            imagemASalvar = imgTemp;
            graphicsImagemASalvar = graphicsImgTemp;
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); // Janela para salvar arquivos
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg"; // Atribuindo formatos de imagem para o usuário escolher
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Definindo a extensão da imagem que iremos salvar
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
