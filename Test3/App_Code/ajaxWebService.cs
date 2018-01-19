using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
// REMEMBER TO ADD THIS NAMESPACE
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Xml;
using System.ServiceModel.Syndication;

/// <summary>
/// Summary description for ajaxWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService] // REMEMBER TO UNCOMMENT THIS LINE
public class ajaxWebService : System.Web.Services.WebService
{

    public ajaxWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    //--------------START---------------
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string Hadmayot()
    {
        List<Hadmaya> list = new List<Hadmaya>();
        string url = "http://feeds.podiant.co/retter/rss.xml";
        XmlReader reader = XmlReader.Create(url);
        SyndicationFeed feed = SyndicationFeed.Load(reader);
        reader.Close();
        foreach (SyndicationItem item in feed.Items)
        {
            string title = item.Title.Text.ToString();
            // string uri = item.Links[0].Uri.ToString() + "embed";
            string audioUrl = item.Links[1].Uri.ToString();
            string type = item.Links[1].MediaType;
            // Hadmaya h = new Hadmaya(title, uri);
            Hadmaya h = new Hadmaya(title, audioUrl, type);

            list.Add(h);
        }
        // create a json serializer objetct
        JavaScriptSerializer js = new JavaScriptSerializer();
        // serialize to string
        string jsonString = js.Serialize(list);
        return jsonString;

    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string getTitles()
    {
        List<Hadmaya> list = new List<Hadmaya>();
        string url = "http://feeds.podiant.co/retter/rss.xml";
        XmlReader reader = XmlReader.Create(url);
        SyndicationFeed feed = SyndicationFeed.Load(reader);
        reader.Close();
        foreach (SyndicationItem item in feed.Items)
        {
            string title = item.Title.Text.ToString();
            Hadmaya h = new Hadmaya();
            h.Title = title;
            list.Add(h);
        }
        JavaScriptSerializer js = new JavaScriptSerializer();
        // serialize to string
        string jsonString = js.Serialize(list);
        return jsonString;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetHadmayaById(string id)
    {
        List<Hadmaya> list = new List<Hadmaya>();
        string url = "http://feeds.podiant.co/retter/rss.xml";
        XmlReader reader = XmlReader.Create(url);
        SyndicationFeed feed = SyndicationFeed.Load(reader);
        reader.Close();
        Hadmaya h = new Hadmaya();
        foreach (SyndicationItem item in feed.Items)
        {
            if (id == item.Title.Text.ToString())
            {
                string title = item.Title.Text.ToString();
                // string uri = item.Links[0].Uri.ToString() + "embed";
                string audioUrl = item.Links[1].Uri.ToString();
                string type = item.Links[1].MediaType;
                // Hadmaya h = new Hadmaya(title, uri);
                h = new Hadmaya(title, audioUrl, type);
                //list.Add(h);
            }
        }
        // create a json serializer objetct
        JavaScriptSerializer js = new JavaScriptSerializer();
        // serialize to string
        string jsonString = js.Serialize(h);
        return jsonString;
    }
}