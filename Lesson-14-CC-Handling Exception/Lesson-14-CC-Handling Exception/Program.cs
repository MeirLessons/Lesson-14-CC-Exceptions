using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_14_CC_Handling_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());//string 
                if (x < 0)
                {
                    NegativeException nex = new NegativeException("input was negative number");
                    throw nex;
                }

                Exception e = new Exception("Error");
                GetException(e);
                Foo();

                Response r = null;
                //r = ReadResponse();
                if(r != null)
                    Console.WriteLine(r.MyProperty);
            }
            catch(NegativeException exx)
            {
                Console.WriteLine(exx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                Console.WriteLine(ex.GetType());
            }
        }
        static void Foo()
        {
            try
            {
                Goo();
            }
            catch (FormatException fmtExp)
            {
                Console.WriteLine(fmtExp.Message);
                Console.WriteLine(fmtExp.StackTrace);
                Console.WriteLine();
                Console.WriteLine(fmtExp.GetType());
            }

            catch (NullReferenceException nullExp)
            {
                return;
            }
            finally
            {
                Console.WriteLine("Close Database Connection 2");
            }
        }
        static int Goo()
        {
            int x = 0;
            int y = 0;
            try
            {
                Console.WriteLine("Open Database Connection");
                y = int.Parse(Console.ReadLine());//moom
                x = int.Parse(Console.ReadLine());//moom
                Console.WriteLine(y / x);
                int[] arr = new int[3];
                Console.WriteLine(arr[6]);
               

                //Doo();
                //}
                //catch (DivideByZeroException divExp)
                //{
                //    Console.WriteLine("Specific For Div By Zero");
                //}
                //catch (NullReferenceException nullExp)
                //{
            }
            catch (DivideByZeroException divExp) when (y == 0)
            {
                Console.WriteLine("Specific For Div Zero By Zero");
            }
            catch (DivideByZeroException divExp)
            {
                Console.WriteLine("Specific For Div Number By Zero");
            }
            catch (NullReferenceException nullExp)
            {
                return 1;
            }
            finally
            {
                Console.WriteLine("Close Database Connection 1");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Console.WriteLine(5/2);
            Console.WriteLine(6/4);
            Console.WriteLine(3/2);

            return 3;
        }

        static void Doo()
        {
            int[] arr = { 1, 3, 5 };
            if(arr.Length >= 7)
                Console.WriteLine(arr[6]);
        }

        static void GetException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    class Response
    {
        public string MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
}
