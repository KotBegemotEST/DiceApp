using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form{

        Random dice = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNum1 = dice.Next(1,7);
            int randomNum2 = dice.Next(1, 7);

            switch (randomNum1) {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice2.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }



            switch (randomNum2)
            {
                case 1:

                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice1.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:

                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice2.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                case 3:

                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice3.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:

                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice4.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                case 5:
                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice5.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:

                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice6.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox3.ImageLocation = @"C:\Users\buket\source\repos\WindowsFormsApp1\WindowsFormsApp1\img\dice1.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


                    break;

            }
            string summ = Convert.ToString(randomNum1 + randomNum2);

            label1.Text = "numbers fell out " + randomNum1 + " and " + randomNum2 + " total amount is: " + summ;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
