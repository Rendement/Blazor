namespace Rendement.Blazor.UI.Interfaces
{
    public interface IParagraphService : ISentenceService
    {
        string? GetFirstParagraph(string? input);
        string? GetParagraph(string? input, int paragraphIndex);
        string? GetParagraphs(string? input, int startIndex, int length);
        string? GetParagraphsFromStart(string? input, int length);
        string? GetParagraphsFromEnd(string? input, int length);
        string? GetParagraphEachSentenceWithFirstLetterUppercase(string? input, int paragraphIndex);
    }
}