using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hadmaya
/// </summary>
public class Hadmaya
{
    string title;
    public string Title { get; set; }
    string url;
    public string Url { get; set; }
    string mediaType;
    public string MediaType { get; set; }
    public Hadmaya()
    {

    }

    public Hadmaya(string title,string url, string mediaType)
    {
        Title = title;
        Url = url;
        MediaType = mediaType;
    }
}