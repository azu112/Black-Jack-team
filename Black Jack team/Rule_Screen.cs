using System;
using System.Windows.Forms;

namespace Black_Jack_team
{
    public partial class Rule_Screen : Form
    {
        public Rule_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //Top_Screenを表示
            Top_Screen top = new Top_Screen();
            top.Show();
        }

        private void Rule_Screen_Load(object sender, EventArgs e)
        {

        }

        private void Rule_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
