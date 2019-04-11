using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            txt_message.Text = message;
        }
    }
}
