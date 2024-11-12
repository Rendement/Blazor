namespace Rendement.Blazor.UI.Interfaces
{
    public interface ISentenceService : IWordService
    {
        string? GetFirstSentence(string? input);
        string? GetSentence(string? input, int sentenceIndex);
        string? GetSentences(string? input, int startIndex, int length);
        string? GetSentencesFromStart(string? input, int length);
        string? GetSentencesFromEnd(string? input, int length);
        string? GetLastSentence(string? input);
        
    }
}