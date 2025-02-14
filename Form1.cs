namespace Cronometro

{

    public partial class Cronometro : Form

    {

        public Cronometro()

        {
            InitializeComponent();
        }

        public int alterar_modo = 0;
        public int segundos = 0;
        public int minutos = 0;
        public int horas = 0;
        public int iniciar = 0;
        private void Cronometro_Load(object sender, EventArgs e)

        {

        }
        private void botaoOval1_Click(object sender, EventArgs e)

        {

        }

        private void botaoOval1_Click_1(object sender, EventArgs e)

        {
            if (alterar_modo == 1)
            {
                if (iniciar == 0)
                {
                    iniciar = 1;
                    botaoOval1.Text = "Parar";
                }
                else
                {
                    iniciar = 0;
                    botaoOval1.Text = "Iniciar";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            if (iniciar == 0 && alterar_modo == 1)
            {

            }
            if (alterar_modo == 0)
            {
                label1.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (alterar_modo == 1 && iniciar == 1)
            {

                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }
                if (minutos == 60)
                {
                    minutos = 0;
                    horas++;
                }

                label1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)

        {



        }

        private void botaoOval3_Click(object sender, EventArgs e)

        {
            if (alterar_modo == 0)
            {
                alterar_modo = 1;

                label1.Text = "00:00:00";
            }
            else
            {
                alterar_modo = 0;
            }
        }

        private void botaoOval2_Click(object sender, EventArgs e)
        {
            if (alterar_modo == 1)
            {
                iniciar = 0;
                label1.Text = "00:00:00";
                segundos = 0; minutos = 0; horas = 0;
                botaoOval1.Text = "Iniciar";
            }
        }
    }

}

