namespace Rendement.Blazor.UI.Interfaces
{
    public interface IWordService
    {
        string? GetFirstWord(string? input);
        string? GetLastWord(string? input);
        string? GetWord(string? input, int wordIndex);
        string? GetWords(string? input, int startIndex, int length);
        string? GetWordsFromStart(string? input, int length);
        string? GetWordsFromEnd(string? input, int length);
        string? GetWordWithFirstLetterUppercase(string? input, int wordIndex);
    }
}