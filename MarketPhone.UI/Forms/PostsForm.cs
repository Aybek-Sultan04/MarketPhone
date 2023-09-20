using Infrastructure;
using Infrastructure.PictureDb;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MarketPhone.UI.Forms
{
    public partial class PostsForm : Form
    {
        public PostsForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image image = Image.FromFile(ofd.FileName))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, image.RawFormat);
                            imageBytes = ms.ToArray();
                            PictureService pictureService = new PictureService();
                            using (var mss = new MemoryStream(imageBytes))
                            {
                                Panel panel = new Panel();
                                PictureBox pb = new PictureBox();
                                pb.Image = Image.FromStream(ms);
                                pb.Location = new Point(0, 0);
                                pb.Size = new Size(512, 512); // Размер PictureBox
                                panel.Controls.Add(pb);
                                TextBox textBox = new TextBox();
                                textBox.Location = new Point(520, 20);
                                textBox.Multiline = true;
                                textBox.Size = new Size(250, 50);
                                pictureService.AddImages(imageBytes, textBox.Text);
                            }
                            MessageBox.Show("Save");
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new ImagesDb())
            {
                // Запрос для получения изображений
                var images = context.Images.ToList();
                context.SaveChanges();
                // Создание панели с автопрокруткой
                Panel panel = new Panel();
                panel.Controls.Clear();
                panel.Refresh();
                panel.AutoScroll = true;
                panel.Location = new Point(0, 0);
                panel.Size = new Size(780, 600); // Размер панели
                this.Controls.Add(panel);

                // Начальная позиция для первого PictureBox
                int yPos = 10;

                foreach (var imageBytes in images)
                {
                    using (var ms = new MemoryStream(imageBytes.Image))
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromStream(ms);
                        pb.Location = new Point(10, yPos);
                        pb.Size = new Size(512, 512); // Размер PictureBox
                        panel.Controls.Add(pb);

                        Label lbl = new Label();
                        lbl.Text = imageBytes.Description;
                        lbl.Location = new Point(530, yPos);
                        lbl.Size = new Size(70, 100); // Размер Label
                        panel.Controls.Add(lbl);
                        // Обновляем позицию для следующего PictureBox
                        yPos += 522; // 100 - это высота PictureBox, 10 - это промежуток между PictureBox'ами
                    }
                }

            }

        }


    }
}
