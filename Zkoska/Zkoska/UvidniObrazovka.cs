namespace Zkoska
{
    public partial class Pojistovna : Form
    {
        private SpravceOsobRegistrace spravceOsobRegistrace = new SpravceOsobRegistrace();
        public Pojistovna()
        {
            InitializeComponent();
            
        }

        private void btnRegistrace_Click(object sender, EventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }
    }
}
