namespace FastDex;

/// <summary>
/// Document in an index.
/// </summary>
public class IndexDocument
{
    /// <summary>
    /// Text content of the document
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Unique ID
    /// </summary>
    public string Id { get; set; }

    public IndexDocument(string id, string content)
    {
        Content = content;
        Id = id;
    }

    public IndexDocument()
    {
        
    }
}

/// <summary>
/// Found document in an index.
/// </summary>
public class SearchResult
{
    /// <summary>
    /// Content of the document found.
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// ID of the document.
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// Char index where the match started.
    /// </summary>
    public int MatchStartIndex { get; set; }

    internal SearchResult()
    {
        
    }
}