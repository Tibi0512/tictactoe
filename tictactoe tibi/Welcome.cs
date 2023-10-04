namespace tictactoe_tibi
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Loginclick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Please insert username");
            }
            else
            {

                SelectOponent selectOponent = new SelectOponent();
                selectOponent.FormClosed += SelectOponent_FormClosed;
                selectOponent.Show();
                this.Hide();
            }
           
        }

        private void SelectOponent_FormClosed(object? sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
    }
}