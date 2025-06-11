class HelloWorld {
    static void Main() {
        string input = "My name Nazir is longestword zazir";
        string[] words = input.Split(' ');
        
        var abc= words.OrderByDescending(x=> x.Length).First(); 
        var abc2= words.OrderByDescending(x=>x).FirstOrDefault();
        var abc1= words.OrderByDescending(x=>x);
        foreach(var item in abc1)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("max substring is {0} and len is {1}", abc, abc.Length);
       
        // Using without linq
      string longestWord = "";
        int maxLength = 0;
        string currentWord = "";

        for (int i = 0; i <= input.Length; i++)
        {
            //Console.Write($"{i}");
            //Console.WriteLine($"{input[i]}");
            if (i < input.Length && input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                if (currentWord.Length > maxLength)
                {
                    maxLength = currentWord.Length;
                    longestWord = currentWord;
                }
                currentWord = ""; // Reset for next word
            }
        }

        Console.WriteLine("Longest word: " + longestWord);
        Console.WriteLine("Length: " + maxLength);
        
    }
}
