using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zkoska
{
    public partial class RegisterWindow : Form
    {
        private SpravceOsobRegistrace spravceOsobRegistrace = new SpravceOsobRegistrace();

        
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrrovat_Click(object sender, EventArgs e)
        {
            try
            {
                spravceOsobRegistrace.Registruj(txtName.Text, txtPrijmeni.Text, txtPrezdivka.Text, txtHeslo.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
