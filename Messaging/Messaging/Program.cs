namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> @string = new List<char>();
            @string.AddRange(Console.ReadLine());
            for (int i = 0; i < nums.Count; ++i)
            {
                int sum = 0;
                while (nums[i] != 0)
                {
                    sum += nums[i] % 10;
                    nums[i] /= 10;
                }
                int t = sum / @string.Count;
                sum = sum - t * @string.Count;
                Console.Write(@string[sum]);
                @string.RemoveAt(sum);
            }
        }
    }
}