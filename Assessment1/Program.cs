namespace Assessment1
{
    public class Program
    {
        static void Main(string[] args)
        {

             
            var arrayCheck = IntegerEvaluator(new int[] { 8, 8});

            Console.WriteLine($"Array OutPut: { arrayCheck}");
        }



        internal static int IntegerEvaluator(int[] nums)
        { 
            var total = 0;

            if (nums == null || nums.Length == 0)
                return 0;


            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    total +=1;

                    if (num == 8)
                    {
                        total += 5;
                    }
                     
                }                 
                else
                {
                    total +=3;
                     
                }              

            }

            return total;
        }
    }
}
