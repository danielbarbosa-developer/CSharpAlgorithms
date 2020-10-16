using System;
using System.Linq;

namespace Math
{
    public class Conversion
    {
        // It converts a decimal number to binary
        public string DecimalToBinary(int decimalNumber)
        {
            int binary;
            string binaryString = "";
            while(decimalNumber >= 1)
            {
                if (decimalNumber == 1)
                {
                    binaryString += Convert.ToString(decimalNumber);
                    break;
                }
                else
                {
                    binary = decimalNumber % 2;
                    binaryString += Convert.ToString(binary);
                    decimalNumber /= 2;
                    Convert.ToInt32(binary);
                }
            }
            string binaryResult = new string(binaryString.Reverse().ToArray());
            return binaryResult;// return the binary as a string
        }
    }
}
