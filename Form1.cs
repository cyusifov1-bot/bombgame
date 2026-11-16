using System.Media;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        Random r = new Random();
        Random g = new Random();
        Random b = new Random();

        Random xL = new Random();
        Random yL = new Random();
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Size = new Size(60, 60);
            p.Location = new Point(xL.Next(0, 740), yL.Next(0, 300));
            p.BackColor = Color.FromArgb(r.Next(0, 256), g.Next(0, 256), b.Next(0, 256));
            this.Controls.Add(p);
            count++;
            label2.Text = count.ToString();
            if (p.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                DialogResult d = MessageBox.Show("Oyun bitdi.Yeni oyun üçün Ok düyməsinə basın","İnformasiya" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();

                    count = 0;
                    label2.Text = count.ToString();
                    while (this.Controls.Count > 0)
                    {
                        this.Controls.RemoveAt(count);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(xL.Next(0, 740), yL.Next(0, 330));
        }
    }
}