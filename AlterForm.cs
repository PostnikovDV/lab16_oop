using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba16_OOP
{
    public partial class AlterForm : Form
    {
        public AlterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.IsInt(textBox1.Text) && Program.IsInt(textBox2.Text) && Program.list.Count >= 1)
            {
                Program.list[int.Parse(textBox1.Text) - 1].Age = int.Parse(textBox2.Text);
                Close();
            }
            else
            {
                var errorFoem = new ErrorFoem();
                errorFoem.ShowDialog();
            }
        }
    }
}
