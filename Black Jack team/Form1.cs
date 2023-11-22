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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //GameScreenを表示
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Rule_Button_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //RuleScreenを表示
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
