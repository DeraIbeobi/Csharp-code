
namespace Variable
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 1000;
            byte byt = (byte) i;
            System.Console.WriteLine(byt);

            var number = "1234";
            int ii = Convert.ToInt32(number);
            System.Console.WriteLine(ii);

            
            var aa = 2;
            var bb = 4;
            var ac = 6;
            System.Console.WriteLine((float)(aa * bb) / (float)ac);

            var a = 1;
            var b = 2;
            var c = 3;
            System.Console.WriteLine(c > b && c > a);
            System.Console.WriteLine(!(c > b || c == a));


            /*try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte");
                throw;
            }*/
        }
    }
}
