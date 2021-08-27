using System;
using System.Diagnostics.Contracts;

#pragma warning disable 3;
namespace Simulate
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                Codes.StartPoint();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            finally
            {

            }
        }
    }
}
