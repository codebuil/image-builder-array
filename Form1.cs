using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x=0;
            int y = 0;
            byte[] b;
            String gs="";
            button1.Text= "loading wait...";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.Load();
            Bitmap image1 = new Bitmap(openFileDialog1.FileName, true);
            

            gs = "bitmap = new Bitmap("+ pictureBox1.Image.Width.ToString()+" , "+ pictureBox1.Image.Height.ToString() +", new byte[] {\r\n" ;
            Application.DoEvents();
            for (y=0; y < pictureBox1.Image.Height; y++)
            {
                for (x = 0; x < pictureBox1.Image.Width; x++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    gs = gs + "0xFF,";
                    gs = gs + pixelColor.R.ToString() + " , ";
                    gs = gs + pixelColor.G.ToString()+" , ";
                    gs = gs + pixelColor.B.ToString() + " , \r\n";
                    
                }

           }
            gs = gs + "0};";
            textBox1.Text =gs;
            button1.Text = "open bitmap";
        }
    }
}