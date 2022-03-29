using System.Text;
namespace examples_Extention.Helper
{
    static class Extention
    {
        public static StringBuilder Reverse(this string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }
            return result;
        }
        public static int Pow(this int num,int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            { result *= num; }
            return result;
        } 
    }
}
