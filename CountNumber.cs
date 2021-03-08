using System;
using System.Linq;
namespace TestCalculator

{

    public class CountNumber
    {
       public decimal num1;
         public decimal num2;
      public   int num3;
       public int num4 ;
        public int resultm;
        public   int[] Addarry = {1,3,4 };
       public  int[] subtract = { 30,10, 15};
        //Const
        public CountNumber(decimal num1, decimal num2, int num3, int num4,
           int resultm, int resultd, int[] Addarry, int[] subtract)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.resultm = resultm;
            this.resultd = resultd;
            this.Addarray = Addarray;
            this.subtract = subtract;
        }
        public static void CountAdd()
        {
            int[] Addarray = { 1, 2, 3, 1 };
            int sum = Addarray.Sum();
            Console.WriteLine(sum);

        }
        public int Addarray
        {
            get { return Addarray; }
            set { Addarray = value; }
        }

        public static void CountSubtracton()
        {
            int[] subtracts = new int[3] { 30, 10, 15 };
            Console.WriteLine(subtracts[0] + subtracts[1] - subtracts[2]);
        }
        public int subtracts
        {
            get { return subtracts; }
            set { subtracts = value; }
        }

        public static decimal Devition(int num1, int num2)
        {
            return num1 / num2;
            try
            {
                decimal resultd = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (num1 / num2 == 0)
            {
                Console.WriteLine("Sorry you can't  divide by 0 ");

            }
            else if (num1 == 0 && num2 == 0)
            {
                Console.WriteLine("This system is not accept divide by zero");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
        public int resultd
        {
            get { return resultd; }
            set { resultd = value; }
        }
        public static int Multiplacation(int num3, int num4)
        {

            return num3 * num4;
        }

        public int result
        {
            get { return resultm; }
            set { resultm = value; }
        }

    }
}
