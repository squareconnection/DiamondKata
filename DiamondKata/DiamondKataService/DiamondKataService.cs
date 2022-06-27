using System;
using System.Runtime.CompilerServices;
using System.Text;
using DiamondKata.Contracts;

[assembly: InternalsVisibleTo("DiamondKataService.Tests")]
namespace DiamondKata.Services
{
    public class DiamondKataService : IDiamondKataService
    {
        internal string PrintLine(char character, int maxLineLength)
        {
            StringBuilder sb = new StringBuilder();
            //get what number of iterations this char should be
            int alphaPosition = char.ToUpper(character) - 64;
            int lineLength = alphaPosition == 1 ? 1 : alphaPosition + (alphaPosition - 1);
            int trailingSpaces = lineLength == maxLineLength ? 0 : (maxLineLength - lineLength) / 2;

            sb.Append(new string(' ', trailingSpaces) + character);
            if(lineLength==1) //letter A, which is a bit different
            {
                sb.Append(new string(' ', trailingSpaces));
            }
            else{
                sb.Append(new string(' ', lineLength-2)); 
                sb.Append(character + new string(' ', trailingSpaces));
            }

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
