namespace Younes
{
    public partial class Form1 : Form
    {
        private string userRole;
        public Form1(string role)
        {

            InitializeComponent();
            userRole = role;
             AfficherTableauDeBord();
            
        }

        public Form1()
        {
        }

        private void AfficherTableauDeBord()
        {
            // Masquer tous les panels d'abord
            panelAdmin.Visible = false;
            panelChefProjet.Visible = false;
            panelChefEquipe.Visible = false;
            panelMembreEquipe.Visible = false; // Ici, plus d'erreur

            // Afficher un panel par défaut si nécessaire
            panelAdmin.Visible = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelMembreEquipe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
