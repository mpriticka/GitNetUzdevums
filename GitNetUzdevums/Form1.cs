using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitNetUzdevums
{
    public class Form1 : Form
    {
        private GroupBox groupBox;
        private Button drawButton;

        public Form1()
        {
            this.Text = "GitNet Uzdevums";
            this.Width = 600;
            this.Height = 400;

            groupBox = new GroupBox();
            groupBox.Text = "Marija Priticka";
            groupBox.Location = new Point(30, 30);
            groupBox.Size = new Size(200, 100);

            drawButton = new Button();
            drawButton.Text = "sin(x)";
            drawButton.Location = new Point(50, 40);
            drawButton.Click += DrawButton_Click;

            groupBox.Controls.Add(drawButton);
            this.Controls.Add(groupBox);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            for (int x = 0; x < 360; x++)
            {
                int y = (int)(100 * Math.Sin(x * Math.PI / 180));
                g.DrawEllipse(pen, x + 250, 150 - y, 2, 2);
            }
        }
    }
}
