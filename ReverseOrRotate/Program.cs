namespace ReverseOrRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "123456789123456789";
            int chunkSize = 4;
            List<string> temporaryList = new List<string>();


            while (text.Length > chunkSize)
            {
                temporaryList.Add(text.Substring(0, chunkSize));
                text = text.Substring(chunkSize);
                if (text.Length < chunkSize) 
                {
                    break;
                }
            }

            

            foreach (string abc in temporaryList)
            {
                Console.WriteLine(abc);
            }

        }

        private bool IsSumOfCubesDivisibleByTwo(string text)
        {
            var sum = 0;
            foreach(char c in text)
            {
                var cube = IncreaseByCube(c);
                sum += cube;
            }
            return sum % 2 == 0;
        }

        private int IncreaseByCube(int number)
        {
            return (int)Math.Pow(Convert.ToInt32(number), 3);
        }
    }
}