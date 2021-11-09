using System;

namespace artieksi
{
 class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(string arr)
    {
         char[] bosluk = new char[] { ' ', '.' };

         string[] sayi = arr.Split(bosluk, StringSplitOptions.RemoveEmptyEntries);
         decimal pozitif = 0;
         decimal negatif = 0;
         decimal sifir = 0 ;
         
          foreach (var sub in sayi)
            {
             int b = int.Parse(sub);
             decimal artieksi= b<0 ? negatif++ : b>0 ? pozitif++ : sifir++ ;
            }
            decimal k = pozitif+negatif+sifir ;
         decimal pson=Convert.ToDecimal( pozitif/k) ;
         string pson1=string.Format("{0:0.000000}", pson); 
         decimal nson=Convert.ToDecimal( negatif/k) ;
         string nson1=string.Format("{0:0.000000}", nson);
         decimal sson=Convert.ToDecimal( sifir/k);
         string sson1=string.Format("{0:0.000000}", sson);

          Console.WriteLine(pson1);
          Console.WriteLine(nson1);
          Console.WriteLine(sson1);
    }

}

class Solution
 {
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string arr = Console.ReadLine();

        Result.plusMinus(arr);
        
    }
}
}


