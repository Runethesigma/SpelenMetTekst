namespace SpelenMetTekst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IsButton_Click(object sender, EventArgs e)
        {
            IsLabel.Visible = true;
            HeelButton.Visible = true;
            IsButton.Visible = false;
        }

        private void HeelButton_Click(object sender, EventArgs e)
        {
            HeelButton.Visible = false;
            HeelLabel.Visible = true;
            TofButton.Visible = true;
        }

        private void TofButton_Click(object sender, EventArgs e)
        {
            TofButton.Visible = false;
            TofLabel.Visible = true;
            VraagtekenButton.Visible = true;
        }

        private void VraagtekenButton_Click(object sender, EventArgs e)
        {
            VraagtekenButton.Visible = false;
            SuperLabel.Visible = true;
            HeelLabel.Visible = false;
            HeelDoorstreeptLabel.Visible = true;
        }
    }
}
