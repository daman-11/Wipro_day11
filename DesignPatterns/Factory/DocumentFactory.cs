using System;

public class DocumentFactory
{
    public static IDocument Create(string type)
    {
        switch (type.ToUpper()) // make it case-insensitive
        {
            case "PDF":
                return new PdfDocument();
            case "WORD":
                return new WordDocument();
            default:
                throw new ArgumentException("Invalid document type");
        }
    }
}
