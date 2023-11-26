namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fNums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> sNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> nList = new List<int>();
            List<int> mList = new List<int>();
            List<int> fList = new List<int>();

            int fNum = 0;
            int sNum = 0;
            int last = 0;
            int prev = 0;

            if (fNums.Count > sNums.Count)
            {
                mList = fNums;
            }

            else
            {
                mList = sNums;
                mList.Reverse();
            }

            for (int i = 0; i < mList.Count; i++)
            {
                last = mList[mList.Count - 1];
                prev = mList[mList.Count - 2];
            }

            for (int i = 0; i < fNums.Count; i++)
            {
                nList.Add(fNums[i]);
            }

            nList.Remove(prev);
            nList.Remove(last);

            for (int i = 0; i < sNums.Count; i++)
            {
                nList.Add(sNums[i]);
            }

            if (prev > last)
            {
                fNum = last;
                sNum = prev;
            }

            else
            {
                sNum = last;
                fNum = prev;
            }

            for (int i = 0; i < nList.Count; i++)
            {
                if (nList[i] > fNum && nList[i] < sNum)
                {
                    fList.Add(nList[i]);
                }
            }

            fList.Sort();

            Console.WriteLine(string.Join(" ", fList));

        }
    }
}