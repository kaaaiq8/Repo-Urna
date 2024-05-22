namespace URNA_ELETRONICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool num1;
        bool num2;

        int redDead, theWitcher, Fifa, Gta, Zelda, Fallout, Hogwarts, Branco;


        public void NCandidato()
        {
            string num1String = txtPersonagem1.Text;
            string num2String = txtPersonagem2.Text;

            string candidato = num1String + num2String;

            switch (candidato)
            {
                case "10":
                    pictureBox2.Image = Properties.Resources.red_dead_red2;
                    label_personagem.Text = "Red Dead Redemption";
                    label_genero.Text = "Ação e Aventura";
                    break;
                case "15":
                    pictureBox2.Image = Properties.Resources.GTA_1;
                    label_personagem.Text = "GTA V";
                    label_genero.Text = "Ação e Aventura";
                    break;
                case "20":
                    pictureBox2.Image = Properties.Resources.final_fantasy_7;
                    label_personagem.Text = "Final Fantasy 7";
                    label_genero.Text = "RPG";
                    break;
                case "25":
                    pictureBox2.Image = Properties.Resources.the_witcher_3;
                    label_personagem.Text = "The Witcher 3";
                    label_genero.Text = "RPG";
                    break;
                case "30":
                    pictureBox2.Image = Properties.Resources.FIFA_1;
                    label_personagem.Text = "Fifa";
                    label_genero.Text = "Esporte";
                    break;
                case "35":
                    pictureBox2.Image = Properties.Resources.IMAGEM_FALLOUT;
                    label_personagem.Text = "Fallout";
                    label_genero.Text = "RPG";
                    break;
                case "40":
                    pictureBox2.Image = Properties.Resources.hogwarts_legacy;
                    label_personagem.Text = "Hogwarts Legacy";
                    label_genero.Text = "RPG";
                    break;

                default:
                    label_personagem.Text = "Personagem inválido!";
                    Gênero.Visible = false;
                    label_genero.Visible = false;
                    btnconfirma.Enabled = false;
                    Nome.Visible = false;
                    break;

            }


        }
        public void desabilitarLabels()
        {
            PERSONAGEM.Visible = false;
            Número.Visible = false;
            Nome.Visible = false;
            Gênero.Visible = false;
            label_personagem.Text = ""; label_personagem.Visible = false;
            label_genero.Text = ""; label_genero.Visible = false;
            txtPersonagem1.Visible = false; txtPersonagem2.Visible = false; txtPersonagem1.Text = ""; txtPersonagem2.Text = "";
            pictureBox2.Image = null; pictureBox2.Visible = false;
            num1 = false;
            num2 = false;
            label_finalizacao.Visible = true;
        }
        public void habilitarLabels()
        {
            PERSONAGEM.Visible = true;
            Número.Visible = true;
            Nome.Visible = true;
            Gênero.Visible = true;
            label_personagem.Visible = true;
            label_genero.Visible = true;
            txtPersonagem1.Visible = true; txtPersonagem2.Visible = true;
            pictureBox2.Visible = true;
            label_finalizacao.Visible = false;
        }
        private void txtPersonagem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonagem2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "1";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "1"; num2 = true; NCandidato(); }
            }




        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "2";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "2"; num2 = true; NCandidato(); }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "3";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "3"; num2 = true; NCandidato(); }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "4";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "4"; num2 = true; NCandidato(); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "5";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "5"; num2 = true; NCandidato(); }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "6";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "6"; num2 = true; NCandidato(); }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "7";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "7"; num2 = true; NCandidato(); }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "8";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "8"; num2 = true; NCandidato(); }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "9";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "9"; num2 = true; NCandidato(); }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (num2 == true) { }

            if (txtPersonagem1.Text == "")
            {
                txtPersonagem1.Text = "1";
                num1 = true;
            }
            else if (num2 == true)
            {

            }
            else
            {
                { txtPersonagem2.Text = "0"; num2 = true; NCandidato(); }
            }

        }

        private void btncorrige_Click(object sender, EventArgs e)
        {
            txtPersonagem1.Text = "";
            txtPersonagem2.Text = "";
            pictureBox2.Image = null;
            num2 = false;

            Gênero.Visible = true;
            label_genero.Visible = true;
            btnconfirma.Enabled = true;
            label_genero.Text = null;
            label_personagem.Text = null;
            Nome.Visible = true;

        }

        private async void btnconfirma_Click(object sender, EventArgs e)
        {
            switch (label_personagem.Text)
            {
                case "Red Dead Redemption":
                    redDead++;
                    break;
                case "GTA V":
                    Gta++;
                    break;
                case "The Witcher 3":
                    theWitcher++;
                    break;
                case "Fifa":
                    Fifa++;
                    break;
                case "Zelda":
                    Zelda++;
                    break;
                case "Fallout":
                    Fallout++;
                    break;
                case "Hogwarts Legacy":
                    Hogwarts++;
                    break;
            }
            desabilitarLabels();
            await Task.Delay(3000);
            habilitarLabels();

        }

        private void label_genero_Click(object sender, EventArgs e)
        {

        }

        private void label_personagem_Click(object sender, EventArgs e)
        {

        }

        private void btnbranco_Click(object sender, EventArgs e)
        {

        }
    }
}
