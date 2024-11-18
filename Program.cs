namespace TwoSum
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            //int target = 9;
            //int[] nums = [2, 7, 11, 15];

            //int target = 6;
            //int[] nums = [3, 2, 4];

            int target = 11;
            int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];

            var result = TwoSum(nums, target);

            Console.WriteLine($"Target: {target}");
            Console.Write("Nums: [");

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    Console.Write($"{nums[i]}");
                }
                else
                {
                    Console.Write($"{nums[i]},");
                }
            }

            Console.WriteLine("]");
            Console.WriteLine($"[{result[0]},{result[1]}]");
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var maps = new List<Map>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = new Map { Index = i, Value = nums[i] };
                var diff = target - current.Value;
                var foundMap = maps.Find(x => x.Value == diff);

                if (foundMap == null)
                {
                    maps.Add(current);
                }
                else
                {
                    result[0] = foundMap.Index;
                    result[1] = i;

                    break;
                }
            }

            return result;
        }
    }
}