namespace Web.UI.Classes
{
    internal class TextModifier
    {        

        public TextModifier()
        {
        }

        public string? ToUpper(string? input)
        {
            return input?.ToUpper();
        }

        public string? ToLower(string? input)
        {
            return input?.ToLower();
        }

        public string? Capitalize(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
        }

        public string? Reverse(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string? Trim(string? input)
        {
            return input?.Trim();
        }

        public string? TrimStart(string? input)
        {
            return input?.TrimStart();
        }

        public string? TrimEnd(string? input)
        {
            return input?.TrimEnd();
        }

        public string? Replace(string? input, string oldValue, string newValue)
        {
            return input?.Replace(oldValue, newValue);
        }

        public string? Remove(string? input, int startIndex, int count)
        {
            return input?.Remove(startIndex, count);
        }

        public string? Insert(string? input, int index, string value)
        {
            return input?.Insert(index, value);
        }

        public string? Substring(string? input, int startIndex, int length)
        {
            return input?.Substring(startIndex, length);
        }

        public string? Concat(string? input1, string? input2)
        {
            return input1 + input2;
        }


    }
}