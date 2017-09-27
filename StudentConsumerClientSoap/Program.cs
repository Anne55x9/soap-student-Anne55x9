using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentConsumerClientSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReference1.StudentClient("BasicHttpBinding_IStudent1")) 
            {
                foreach (var st in client.GetAll())
                {
                    Console.WriteLine(st);
                }
                 
                
                Console.ReadLine();
            
            }
        }
    }
}
