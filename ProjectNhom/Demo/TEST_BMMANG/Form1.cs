using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_BMMANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofdImage;
        OpenFileDialog ofdFile;
        Bitmap bmp;
        const int sizeAlloc = 512;
        OpenFileDialog decryptOfd;
        string openpath = "";
        private void btn_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\dotha\Downloads";

            if(openDialog.ShowDialog()== DialogResult.OK)
            {
                txt_FilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = txt_FilePath.Text;
            }


        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(txt_FilePath.Text);
            
            for(int i = 0; i < img.Width; i++)
            {
                for(int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j <txt_message.TextLength)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(txt_message.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter: " + letter + " value: " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));

                    }
                    if( i==img.Width-1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, txt_message.TextLength));
                    }

                }
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            saveFile.InitialDirectory = @"C:\Users\dotha\Downloads";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = txt_FilePath.Text;

                img.Save(txt_FilePath.Text);
            }
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(txt_FilePath.Text);
            string message = "";
            Color lastpixel = img.GetPixel(img.Width-1, img.Height-1);
            int msgLength = lastpixel.B;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;

                    }
                }
            }
            txttextdecode.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdFile = new OpenFileDialog();
            ofdFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                fileAdressTextBox.Text = ofdFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(ofdImage.FileName);
                InputImagePictureBox.Image = bmp;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FileStream fs = new FileStream(ofdFile.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            byte[] bArray = br.ReadBytes((int)fs.Length);
            int size = bArray.Length;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);


            int k = 0;


            int tempSize = size;

            for (int i = 0; i < sizeAlloc; i++)
            {
                byte A = 0, R = 0, G = 0, B = 0;
                byte[] ar = new byte[4] { A, R, G, B };
                for (int h = 0; h < 4; h++)
                {
                    if (tempSize >= 255)
                    {
                        ar[h] = 255;
                        tempSize -= 255;

                    }
                    else if (tempSize < 255)
                    {
                        ar[h] = (byte)tempSize;
                        tempSize = 0;
                    }

                }
                bmp2.SetPixel(i, 0, Color.FromArgb(ar[0], ar[1], ar[2], ar[3])); //TODO : Can allow multi-line length specification
            }
            int count = 0;


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    byte G = bmp.GetPixel(i, j).G;
                    byte B = bmp.GetPixel(i, j).B;

                    if (k < bArray.Length && count > sizeAlloc)
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(255, bArray[k], G, B));
                        k++;
                    }
                    else
                    {
                        byte R = bmp.GetPixel(i, j).R;
                        bmp2.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                    }
                    count++;

                }
                backgroundWorker1.ReportProgress((int)(((double)(i + 1) / (double)bmp.Width) * 100d));
            }

            br.Close();
            fs.Close();
            e.Result = bmp2;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnchouse_Click(object sender, EventArgs e)
        {
            decryptOfd = new OpenFileDialog();
            if (decryptOfd.ShowDialog() == DialogResult.OK)
            {
                openpath = decryptOfd.FileName;
                textBoxDecryption.Text = openpath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp3;

            if (openpath != "")
            {
                bmp3 = new Bitmap(openpath);
            }
            else
            {
                MessageBox.Show("Not put a path");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.PNG)|*.PNG;|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = sfd.FileName;
                FileStream rf = new FileStream(sfd.FileName, FileMode.Create);
                BinaryWriter wr = new BinaryWriter(rf);

                int genSize = 0;

                for (int i = 0; i < sizeAlloc; i++)
                {
                    genSize += bmp3.GetPixel(i, 0).A + bmp3.GetPixel(i, 0).R + bmp3.GetPixel(i, 0).G + bmp3.GetPixel(i, 0).B;
                }

                int k = 0;
                int count = 0;
                for (int i = 0; i < bmp3.Width; i++)
                {
                    for (int j = 0; j < bmp3.Height; j++)
                    {
                        if (k < genSize && count > sizeAlloc)
                        {
                            byte val = bmp3.GetPixel(i, j).R;
                            wr.Write(val);
                            k++;
                        }
                        count++;
                    }
                }
                wr.Close();
                rf.Close();
            }
            MessageBox.Show("Image saved at : " + sfd.FileName);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OutputImagePictureBox.Image = (Bitmap)e.Result;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.PNG)|*.PNG;|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OutputImagePictureBox.Image.Save(sfd.FileName);
            }
        }
    }
}
