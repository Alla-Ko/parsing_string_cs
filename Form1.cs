using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_author_id
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400,Primary.Blue800,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            String r = this.textBox1.Text;

            for (int i = 0; i < 3; i++)
            {
                if (r.IndexOf(";") != -1)
                    r = r.Remove(0, r.IndexOf(";") + 1);
            }
            if (r.IndexOf(";") != -1)
                r = r.Remove(r.IndexOf(";"), r.Length - r.IndexOf(";"));
            this.textBox2.Text = r;
        }


    }
}
