using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 2;
            int b= 3;
            Console.WriteLine(a+b);

            int sonuc= topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek= new Metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

            int sonuc2= ornek.ArttirveTopla(a,b);
            ornek.ekranaYazdir(Convert.ToString(sonuc2));
            ornek.ekranaYazdir(Convert.ToString(a+b));


        }

        static int topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }


    }

    class Metotlar{
        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);

        }
        public int ArttirveTopla(int deger1, int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+ deger2;

        }
    }
}