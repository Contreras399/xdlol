using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdlol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Sabía que diías que sí, te amo!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxX = this.Size.Width - btnNo.Width;
            int maxY = this.Size.Height - btnNo.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            btnNo.Location = new Point(newX, newY);
        }
    }
}
