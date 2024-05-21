namespace IsogramValidation
{
    internal class IsogramValidator
    {
        public static bool CheckIsIsogram(string wordToCheck)
        {
            var wordUniqueChars = new HashSet<char>();
            for (int i = 0; i < wordToCheck.Length; i++)
            {
                var currentCharInLowerCase = char.ToLower(wordToCheck[i]);
                if (wordUniqueChars.Contains(currentCharInLowerCase))
                {
                    return false;
                }
                else
                {
                    wordUniqueChars.Add(currentCharInLowerCase);
                }
            }
            return true;
        }
    }
}
