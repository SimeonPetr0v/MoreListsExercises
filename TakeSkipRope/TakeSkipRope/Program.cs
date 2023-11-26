using System.Text;

namespace TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<int> nums = new List<int>();
            List<int> tList = new List<int>();
            List<int> sList = new List<int>();
            StringBuilder res = new StringBuilder();
            List<string> nonNums = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    nums.Add(int.Parse(word[i].ToString()));
                }
                else
                {
                    nonNums.Add(word[i].ToString());
                }

            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    tList.Add(nums[i]);
                }
                else
                {
                    sList.Add(nums[i]);
                }
            }

            int indexToSkip = 0;

            for (int i = 0; i < tList.Count; i++)
            {
                List<string> temp = new List<string>(nonNums);

                temp = temp.Skip(indexToSkip).Take(tList[i]).ToList();

                res.Append(string.Join("", temp));

                indexToSkip += tList[i] + sList[i];
            }

            Console.WriteLine(res.ToString());
        }
    }
}