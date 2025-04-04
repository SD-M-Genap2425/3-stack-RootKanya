namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public bool ValidasiEkspresi(string expression)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (char ch in expression)
            {
                if (bracketPairs.ContainsValue(ch)) 
                {
                    stack.Push(ch);
                }
                else if (bracketPairs.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[ch])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
