using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack_team
{
    public partial class Top_Screen : Form
    {
        public Top_Screen()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //GameScreenを表示
            Play_Screen Play = new Play_Screen();
            Play.Show();
        }

        private void Rule_Button_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //RuleScreenを表示
            Rule_Screen Rule = new Rule_Screen();
            Rule.Show();
        }

        private void Top_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
