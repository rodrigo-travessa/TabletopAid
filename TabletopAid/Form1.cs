using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace TabletopAid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse card Sheet Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files (*.*)|*.*",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                imageList1.Images.Add(pictureBox1.Image);
                richTextBox1.Text = $"x: {pictureBox1.Image.Width} \n y: {pictureBox1.Image.Height}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int width = pictureBox1.Image.Width;
            int height = pictureBox1.Image.Height;
            int vertSlices = (int)numericUpDown1.Value;
            int horSlices = (int)numericUpDown2.Value;
            int cutCardWidth = width / vertSlices;
            int cutCardHeight = height / horSlices;

            List<Coordinates> coordinates = new List<Coordinates>();
            for (int i = 0; i < vertSlices; i++)
            {
                for (int j = 0; j < horSlices; j++)
                {
                    coordinates.Add(new Coordinates(i * cutCardWidth, j * cutCardHeight, (i + 1) * cutCardWidth, (j + 1) * cutCardHeight));
                }
            }
            int z = 1;
            foreach (Coordinates c in coordinates)
            {
                Bitmap newImage = new Bitmap(c.C - c.A, c.D - c.B);
                Graphics g = Graphics.FromImage(newImage);
                g.DrawImage(pictureBox1.Image, 0, 0, new Rectangle(c.A, c.B, c.C - c.A, c.D - c.B), GraphicsUnit.Pixel);
                g.Dispose();
                newImage.Save($"{label1.Text}\\Imagem{z}.png");
                z++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int width = pictureBox1.Image.Width;
            int height = pictureBox1.Image.Height;
            int vertSlices = (int)numericUpDown1.Value;
            int horSlices = (int)numericUpDown2.Value;
            int cutCardWidth = width / vertSlices;
            int cutCardHeight = height / horSlices;
            listView1.Items.Add(pictureBox1.ImageLocation);
            Bitmap newImage = new Bitmap(pictureBox1.Image);
            Graphics g = Graphics.FromImage(newImage);
            Pen myPen = new Pen(Brushes.HotPink);
            myPen.Width = 3.0F;
            richTextBox1.Text = $"x: {pictureBox1.Image.Width} \n y: {pictureBox1.Image.Height} \n vs {vertSlices} - hs {horSlices} \n ccw: {cutCardWidth} - cch {cutCardHeight}";
            for (int i = 1; i < horSlices; i++)
            {
                g.DrawLine(myPen, 0, i * cutCardHeight, width, i * cutCardHeight);
            }
            for (int i = 1; i < vertSlices; i++)
            {
                g.DrawLine(myPen, i * cutCardWidth, 0, i * cutCardWidth, height);
            }
            pictureBox1.Image = newImage;
            myPen.Dispose();
            g.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Image Name", typeof(string));
                dt.Columns.Add("Path", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                foreach (string str in openFileDialog1.FileNames)
                {
                    dt.Rows.Add(Path.GetFileName(str), str, 1);
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox2.Image = new Bitmap(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

            }
            catch
            {

            }
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a4Width = 2480;
            int a4Height = 3508;

            int stdCardWidth = (int)numericUpDown7.Value;
            int stdCardHeight = (int)numericUpDown8.Value;

            int horBorder = (int)numericUpDown5.Value; 
            int vertBorder = (int)numericUpDown6.Value;

            int cardsPerRow = (int)numericUpDown3.Value;
            int cardsPerColumn = (int)numericUpDown4.Value;

            Bitmap PageToPrint = new Bitmap(  a4Width, a4Height);
            Graphics g = Graphics.FromImage(PageToPrint);
            g.FillRectangle(Brushes.White, 0, 0, a4Width, a4Height);
            pictureBox2.Image = PageToPrint;

            List<string> imgList = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int l = 0; l < (int)dataGridView1.Rows[i].Cells[2].Value; l++)
                {
                    imgList.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            int numOfPages = imgList.Count / (cardsPerColumn * cardsPerRow);
            int pageIndex = 0;
            int imgIndex = 0;
            for (int k = 0; k < numOfPages; k++)
            {

                for (int j = 0; j < cardsPerColumn; j++)
                {
                    for (int i = 0; i < cardsPerRow; i++)
                    {
                        g.DrawImage(new Bitmap(imgList[imgIndex])
                        , 60 + (horBorder * i) + (stdCardWidth * i), 60 + (vertBorder * j) + (stdCardHeight * j), stdCardWidth, stdCardHeight);
                        imgIndex++;
                    }
                }
                PageToPrint.Save($"{label4.Text}\\Page{pageIndex}.png");
                pageIndex++;
            }
            ///create blank image for the page
            ///populaet the blank page, save it to the folder and reset it.

        }

        //Columns
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
        //Rows
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class Coordinates
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public Coordinates(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}
