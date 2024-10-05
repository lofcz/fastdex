# FastDex

Fast inverted index powered by [Lucene .NET](https://github.com/apache/lucenenet).

## Getting Started

Create an index, by default file storage is used:

```cs
// creates directory "myindex" if it doesn't exist, rebuilds stale index if necessarry
InvertedIndex index = new InvertedIndex($"myindex");
```

Add some documents:

```cs
List<IndexDocument> sourceDocuments =
[
    new IndexDocument { Content = "public v[oi]d Method() ú", Id = "1" },
    new IndexDocument { Content = "int x = 5 * 3; ú", Id = "2" },
    new IndexDocument { Content = "if (condition) { }", Id = "3" },
];

/* removes any other documents currently indexed, updates the existing documents if content changed
   can report progress */
index.SynchronizeIndex(sourceDocuments);
```

Alternatively, add/update and delete documents manually:

```cs
index.IndexDocument("document content", "1"); // add/update
index.DeleteDocument("1");
```

Finally, search the index:

```cs
// supported features: case (in)sensitivity, whole words search, paging
List<SearchResult> results = SharedIndex.Search("x =");
```

## Gotchas

- `Dispose()` the index once it's no longer needed.
- The index can be searched, from multiple threads (near realtime).
- The index can be opened only once, use it as a static resource and dispose when closing the application, eg. `lifetime.ApplicationStopping.Register(() => { myindex.Dipose(); });` in .NET Core.
