using System.Net.Http.Headers;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@"C:\test\test.txt");
                sw.WriteLine("Hello");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                sw.Close();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            Console.WriteLine("Done");
        }
    }
    }