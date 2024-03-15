using System.Windows.Forms;

namespace Ứng_Dụng_Quản_Lý_Bán_Sơn_COLORFULL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            var g = e.Graphics;
            var sText = tabControl1.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(sText, tabControl1.Font);
            var iX = e.Bounds.Left + 6;
            var iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
            float selectedFontSize = tabControl1.Font.SizeInPoints + 4;
            if (e.Index == tabControl1.SelectedIndex)
            {
                Font selectedFont = new Font(tabControl1.Font.FontFamily, selectedFontSize, FontStyle.Bold);
                g.DrawString(sText, selectedFont, Brushes.Black, iX, iY);
            }
            else
            {
                g.DrawString(sText, tabControl1.Font, Brushes.Black, iX, iY);
            }
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tabControl1.SelectedTab.Text == "Exit")
                {
                    Application.Exit();
                }
            }
        }
    }
}
