namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive - öz yineleme
            //3^4=3*3*3*3;
            Console.Write("Sayı giriniz : ");
            int taban=Convert.ToInt32(Console.ReadLine());
            Console.Write("Üs giriniz : ");
            int us=Convert.ToInt32(Console.ReadLine());
            int result=1;
            for (int i = 1; i <=us; i++)
            {
                result=result*taban;
            }
            Console.WriteLine(result);
            Islemler instance= new();
            Console.WriteLine(instance.Expo(2,9));
            //extension Metotlar
            string ifade="Emre Başpınar";
            bool sonuc=(ifade.CheckSpaces());
            Console.WriteLine(sonuc);
            if (sonuc) Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeLowerCase());
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi={9,5,6,2,5,1,4,25};
            dizi.SortArray();
            dizi.EkranaYazdir();
            
            int sayi= 5;
            Console.WriteLine();
            Console.WriteLine(sayi.IsEverNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        { 
            if (üs<2)
                return sayi;

         return Expo(sayi,üs-1)*sayi;   
        }
    }
    public static class extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi= param.Split(" ");
            return string.Join("",dizi);

        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
         public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir (this int[] param)
        {
            foreach (var item in param) 
                Console.Write(item+",");
        }
        public static bool IsEverNumber(this int param)
        {
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}