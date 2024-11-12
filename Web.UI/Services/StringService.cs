using Rendement.Blazor.UI.Interfaces;

namespace Rendement.Blazor.UI.Services
{
    public class StringService : IStringService
    {

        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public string? ToUpperCase(string? input)
        {
            return input?.ToUpper();
        }

        public string? ToLowerCase(string? input)
        {
            return input?.ToLower();
        }

        public bool IsNullOrEmpty(string? input)
        {
            return string.IsNullOrEmpty(input);
        }

        public int GetLength(string? input)
        {
            return input?.Length ?? 0;
        }

        public string? GetSubstring(string? input, int startIndex, int length)
        {
            return input?.Substring(startIndex, length);
        }

        public string? GetSubstringFromStart(string? input, int length)
        {
            return input?.Substring(0, length);
        }

        public string? GetSubstringFromEnd(string? input, int length)
        {
            return input?.Substring(input.Length - length, length);
        }

        public string? GetFirstCharacter(string? input)
        {
            return input?.Substring(0, 1);
        }

        public string? GetLastCharacter(string? input)
        {
            return input?.Substring(input.Length - 1, 1);
        }



        public string? GetLastWord(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var lastSpaceIndex = input.LastIndexOf(' ');
            if (lastSpaceIndex == -1)
            {
                return input;
            }

            return input.Substring(lastSpaceIndex + 1);
        }


        public string? GetFirstWord(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var firstSpaceIndex = input.IndexOf(' ');
            if (firstSpaceIndex == -1)
            {
                return input;
            }

            return input.Substring(0, firstSpaceIndex);
        }

        public string? GetWord(string? input, int wordIndex)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var words = input.Split(' ');
            if (wordIndex < 0 || wordIndex >= words.Length)
            {
                return null;
            }

            return words[wordIndex];
        }

        public string? GetWords(string? input, int startIndex, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var words = input.Split(' ');
            if (startIndex < 0 || startIndex >= words.Length)
            {
                return null;
            }

            var endIndex = startIndex + count;
            if (endIndex > words.Length)
            {
                return null;
            }

            return string.Join(' ', words[startIndex..endIndex]);
        }

        

        public string? GetWordsFromStart(string? input, int count)
        {
            return GetWords(input, 0, count);
        }

        public string? GetWordsFromEnd(string? input, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var words = input.Split(' ');
            if (count > words.Length)
            {
                return null;
            }

            return string.Join(' ', words[^count..]);
        }

        public string? GetFirstSentence(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var firstPeriodIndex = input.IndexOf('.');
            if (firstPeriodIndex == -1)
            {
                return input;
            }

            return input.Substring(0, firstPeriodIndex + 1);
        }

        public string? GetLastSentence(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var lastPeriodIndex = input.LastIndexOf('.');
            if (lastPeriodIndex == -1)
            {
                return input;
            }

            return input.Substring(lastPeriodIndex + 1);
        }

        public string? GetSentence(string? input, int sentenceIndex)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var sentences = input.Split('.');
            if (sentenceIndex < 0 || sentenceIndex >= sentences.Length)
            {
                return null;
            }

            return sentences[sentenceIndex];
        }

        public string? GetSentences(string? input, int startIndex, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var sentences = input.Split('.');
            if (startIndex < 0 || startIndex >= sentences.Length)
            {
                return null;
            }

            var endIndex = startIndex + count;
            if (endIndex > sentences.Length)
            {
                return null;
            }

            return string.Join('.', sentences[startIndex..endIndex]);
        }

        public string? GetSentencesFromStart(string? input, int count)
        {
            return GetSentences(input, 0, count);
        }

        public string? GetSentencesFromEnd(string? input, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var sentences = input.Split('.');
            if (count > sentences.Length)
            {
                return null;
            }

            return string.Join('.', sentences[^count..]);
        }

        public string? GetFirstParagraph(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var firstNewLineIndex = input.IndexOf('\n');
            if (firstNewLineIndex == -1)
            {
                return input;
            }

            return input.Substring(0, firstNewLineIndex + 1);
        }

        public string? GetLastParagraph(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var lastNewLineIndex = input.LastIndexOf('\n');
            if (lastNewLineIndex == -1)
            {
                return input;
            }

            return input.Substring(lastNewLineIndex + 1);
        }

        public string? GetParagraph(string? input, int paragraphIndex)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var paragraphs = input.Split('\n');
            if (paragraphIndex < 0 || paragraphIndex >= paragraphs.Length)
            {
                return null;
            }

            return paragraphs[paragraphIndex];
        }

        public string? GetParagraphs(string? input, int startIndex, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var paragraphs = input.Split('\n');
            if (startIndex < 0 || startIndex >= paragraphs.Length)
            {
                return null;
            }

            var endIndex = startIndex + count;
            if (endIndex > paragraphs.Length)
            {
                return null;
            }

            return string.Join('\n', paragraphs[startIndex..endIndex]);
        }

        public string? GetParagraphsFromStart(string? input, int count)
        {
            return GetParagraphs(input, 0, count);
        }

        public string? GetParagraphsFromEnd(string? input, int count)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var paragraphs = input.Split('\n');
            if (count > paragraphs.Length)
            {
                return null;
            }

            return string.Join('\n', paragraphs[^count..]);
        }

        public string? GetWordWithFirstLetterUppercase(string? input, int wordIndex)
        {
            var word = GetWord(input, wordIndex);
            if (word == null)
            {
                return null;
            }
            return ToUpperCase(GetFirstCharacter(word)) + GetSubstring(word, 1, word.Length - 1);
        }

        public string? GetSentenceWithFirstLetterUppercase(string? input, int sentenceIndex)
        {
            var sentence = GetSentence(input, sentenceIndex);
            if (sentence == null)
            {
                return null;
            }
            return ToUpperCase(GetFirstCharacter(sentence)) + GetSubstring(sentence, 1, sentence.Length - 1);
        }

        public string? GetParagraphEachSentenceWithFirstLetterUppercase(string? input, int paragraphIndex)
        {
            var paragraph = GetParagraph(input, paragraphIndex);
            if (paragraph == null)
            {
                return null;
            }
            var sentences = paragraph.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                var updatedSentence = GetSentenceWithFirstLetterUppercase(sentences[i], i);
                if (updatedSentence != null)
                {
                    sentences[i] = updatedSentence;
                }
            }

            return string.Join('.', sentences);
        }




    }

    
}