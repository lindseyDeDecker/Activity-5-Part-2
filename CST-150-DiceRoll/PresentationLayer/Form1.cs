/* Lindsey DeDecker
 * CST - 150
 * July 25, 2024
 * Activity 5 Part 2 - Dice Roll
 */

namespace CST_150_DiceRoll
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            int diceOne = rand.Next(1, 7);
            int diceTwo = rand.Next(1, 7);  

                switch (diceOne)
                {
                    case 1:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die1.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die2.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die3.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die4.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die5.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die6.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;

                    default:
                        picDiceOne.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die1.bmp";
                        picDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }

            switch (diceTwo)
            {
                case 1:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die1.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die2.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die3.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die4.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die5.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die6.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    picDiceTwo.ImageLocation = @"C:\Users\kydec\Desktop\Lindsey School\CSR 150\Activity 5\CST-150-DiceRoll\Dice\Die1.bmp";
                    picDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

        }
       
    }
}
