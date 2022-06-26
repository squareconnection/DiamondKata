using System;
using System.Text;

namespace DiamondKata.Services
{
    public class DiamondKataService
    {
        public string PrintLine(char character, int numIterations)
        {
            StringBuilder sb = new StringBuilder();
            //get what number of iterations this char should be
            int alphaPosition = char.ToUpper(character) - 64;
            int lineLength = alphaPosition == 1 ? 1 : alphaPosition + (alphaPosition - 1);
            int trailingSpaces = 0;


            if (lineLength != numIterations) //if this is not the middle line we need to add spaces at the front of back of the sequence.
            {
                trailingSpaces = (numIterations - lineLength) / 2;
            }

            sb.Append(new string(' ', trailingSpaces));

            for (int n = 1; n <= lineLength; n++)
            {
                if (n % 2 == 0)//even number, print space
                {
                    sb.Append(" ");
                }
                else //odd, print char
                {
                    sb.Append(character);
                }
            }
            sb.Append(new string(' ', trailingSpaces));

            return sb.ToString();
        }
        public string Execute(char character)
        {
            StringBuilder sb = new StringBuilder();
            //get position in alphabet so we know how many times we need to loop through
            int alphaPosition = char.ToUpper(character) - 64;//i.e. A is 65-64=1, B is 66-64=2 etc.

            if (alphaPosition < 64 || alphaPosition > 90)
            {

                //how many chars need to be on the middle row
                int lineLength = alphaPosition == 1 ? 1 : alphaPosition + (alphaPosition - 1);

                for (int n = 1; n <= alphaPosition; n++)
                { //loop to get each line up to and including the middle row
                    sb.AppendLine(PrintLine(((char)(64 + n)), lineLength));
                }

                //now complte the lower row
                for (int n = alphaPosition - 1; n >= 1; n--)
                { //loop to get each line up to and including the middle row
                    sb.AppendLine(PrintLine(((char)(64 + n)), lineLength));
                }

                return sb.ToString();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Only characters A through Z allowed");
            }
        }
    }
}
