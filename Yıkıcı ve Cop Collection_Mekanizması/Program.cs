using System;

namespace Yıkıcı_ve_Cop_Collection_Mekanizması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            new MyClass();//Bu Şekilde nesneye bağlamadan işlem yapıldığında garben collecter temizlik yapar
            GC.Collect();
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass oluştu");
        }
        ~MyClass()
        {
            Console.WriteLine("MyClass Silindi");
        }

        public void yaz()
        {
            Console.WriteLine("Yaz");
        }
    }
}
