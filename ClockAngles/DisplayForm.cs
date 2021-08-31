using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockAngles
{
    public partial class DisplayForm : Form
    {

        
        public DisplayForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            // saat açısı: (saniye etkisiz kabul)
            double angleH = h * 30 + m * 0.5;
            // dakika açısı:
            double angleM = m * 6 + s * 0.1;
            // saniye açısı:
            double angleS = s * 6;

            double hm = Math.Abs(angleH - angleM);
            double ms = Math.Abs(angleM - angleS);
            double hs = Math.Abs(angleH - angleS);

            label1.Text = hm.ToString();
            label2.Text = ms.ToString();
            label3.Text = hs.ToString();
        }
    }
}
