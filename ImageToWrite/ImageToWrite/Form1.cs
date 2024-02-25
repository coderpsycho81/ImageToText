using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace ImageToWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(ımageSelectGrup_DragEnter);
            this.DragDrop += new DragEventHandler(ımageSelectGrup_DragDrop);
        }

        private string ExtractTextFromImage(Bitmap image)
        {
            try
            {
                using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default))
                {
                    using (var page = engine.Process(image, PageSegMode.Auto))
                    {
                        return page.GetText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Metin çıkarma işlemi sırasında bir hata oluştu: " + ex.Message);
                return string.Empty;
            }
        }

        private void ımageSelecet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                using (Bitmap image = new Bitmap(imagePath))
                {
                    string extractedText = ExtractTextFromImage(image);
                    richTextBox1.Text = extractedText;
                }
            }
        }

        private void ımageSelectGrup_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string imagePath = files[0];
                    try
                    {
                        using (Bitmap image = new Bitmap(imagePath))
                        {
                            string extractedText = ExtractTextFromImage(image);
                            richTextBox1.Text = extractedText;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim dosyası okunurken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir resim dosyası sürükleyin.");
            }
        }

        private void ımageSelectGrup_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void copyBTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            MessageBox.Show("Metin panoya kopyalandı.");
        }
    }
}
