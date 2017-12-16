using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{

    public partial class RegisterForm : Form
    {

        public string name;

        public string ID;

        public string password;

        public int number;


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            name = Name.Text;

            password = Password.Text;

            ID = Account.Text;

            number = int.Parse(Number.Text);

        }

    }
}
