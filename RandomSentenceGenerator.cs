namespace RandomSentenceGenerator
{
    internal class RandomSentenceGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michael", "Jane", "Steve", "Maria", "John", "Nicole", "George" };
            string[] places = { "Sofia", "New York", "Berlin", "Denver", "the mountains", "Sydney", "London" };
            string[] verbs = { "eats", "sees", "holds", "plays with", "admires", "brings", };
            string[] nouns = { "stones", "cakes", "apple", "laptop", "bikes", "photo", "bird", "ball", "stick" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "happily", "nervously", "loudly", "awkwardly" };
            string[] details = { "near the river", "at home", "in the park", "downtown", "in the sea", "in the mountains", "abroad", "at the beach", "on the street" };

            Console.WriteLine("Hello, this is your first random-generated sentence");
            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}.";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.ReadLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string randomWord = words[randomIndex];
            return randomWord;
        }
    }
}