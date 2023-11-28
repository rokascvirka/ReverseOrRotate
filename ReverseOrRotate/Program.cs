namespace ReverseOrRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string text = "563000655734469485";
            int chunkSize = 4;
            List<string> temporaryList = new List<string>();
            var processedText = "";


            while (text.Length > chunkSize)
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
                var processed = TextProcessor(chunkText);
                processedText += processed;
            }

            Console.WriteLine(processedText);
            
        }
        private static string TextProcessor(string text)
        {
            string newText = "";
            if(IsSumOfCubesDivisibleByTwo(text))
            {
                var charArray = text.ToCharArray();
                Array.Reverse(charArray);
                var reversed = new string(charArray);
                newText += reversed;
            }
            else
            {
                
                newText += text.Substring(1) + text[0];
            }

            return newText;
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