namespace plkj
{
    public partial class FrmC : Form
    {
        public FrmC()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmI f= new FrmI();
            f.ShowDialog();
              
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
