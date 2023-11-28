namespace ReverseOrRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "123456987654";
            int chunkSize = 6;
            List<string> temporaryList = new List<string>();
            var answer = "";

            if (chunkSize <= 0 || text.Length == 0) Console.WriteLine( "Chunk was 0 or string was empty");

                while (text.Length >= chunkSize)
            {
                temporaryList.Add(text.Substring(0, chunkSize));
                text = text.Substring(chunkSize);
                if (text.Length < chunkSize) 
                {
                    break;
                }
            }        

            foreach (string chunkText in temporaryList)
            {
                Console.WriteLine(chunkText);
                var processedText = TextProcessor(chunkText);
                answer += processedText;
            }

            Console.WriteLine(answer);
            
        }

        private static string TextProcessor(string text)
        {
            string processedText = "";
            if(IsSumOfCubesDivisibleByTwo(text))
            {
                var charArray = text.ToCharArray();
                Array.Reverse(charArray);
                var reversed = new string(charArray);
                processedText += reversed;
            }
            else
            {
                processedText += text.Substring(1) + text[0];
            }

            return processedText;
        }

        private static bool IsSumOfCubesDivisibleByTwo(string text)
        {
            var sum = 0;
            foreach(char c in text)
            {
                var cube = IncreaseByCube(c.ToString());
                sum += cube;
            }
            return sum % 2 == 0;
        }


        private static int IncreaseByCube(string number)
        {
            return (int)Math.Pow(Convert.ToInt32(number), 3);
        }
    }
}