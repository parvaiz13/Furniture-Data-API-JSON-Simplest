#region 
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
#endregion

public partial class API_JSON : System.Web.UI.Page
{
    #region Executue Code on PageLoad
    protected void Page_Load(object sender, EventArgs el)
    {
          List<DataBook> DT = new List<DataBook>{
                   new DataBook{ID = "1 - Dummy Data", TITLE = "Ashlay - Dummy Data", Publishe_Date = "2/2/2 - Dummy Data", Modified_Date="3/3/3 - Dummy Data", Image_Url="noimage - Dummy Data", Store_Detail="The complete store detail - Dummy Data"},
                   };
        
            var json = new JavaScriptSerializer().Serialize(DT);

            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(json);
            Response.End();           

        }
    #endregion

    #region DataBook
    public class DataBook
    {
        string Id, Title, PublishedDate, ModifiedDate, ImageURL, StoreDetail;


        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string TITLE
        {
            get { return Title; }
            set { Title = value; }
        }

        public string Publishe_Date
        {
            get { return PublishedDate; }
            set { PublishedDate = value; }

        }
        public string Modified_Date
        {
            get { return ModifiedDate; }
            set { ModifiedDate = value; }
        }
        public string Image_Url
        {
            get { return ImageURL; }
            set { ImageURL = value; }
        }

        public string Store_Detail
        {
            get { return StoreDetail; }
            set { StoreDetail = value; }
        }
    }
    #endregion
}