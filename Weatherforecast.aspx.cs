using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Weatherapp
{
    public partial class Weatherforecast : System.Web.UI.Page
    {
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            string appId = "ffe3c1e8029bf464527224439455a5b2";
            string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={txtcity.Text.Trim()}&appid={appId}");
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                Root weatherinfo = new JavaScriptSerializer().Deserialize<Root>(json);

                lblcitycountry.Text = weatherinfo.name + "," + weatherinfo.sys.country + ",";
                lblmain.Text = weatherinfo.weather[0].main + ",";
                lbldescription.Text = weatherinfo.weather[0].description + ",";
                lblhumidity.Text = weatherinfo.main.humidity.ToString() + ",";
                lblwind.Text = string.Format("{0}m/s", Math.Round(weatherinfo.wind.speed, 1)) + ",";
                lbltempmin.Text = string.Format("{0}c", Math.Round(weatherinfo.main.temp_min, 1)) + ",";
                lbltempmax.Text = string.Format("{0}c", Math.Round(weatherinfo.main.temp_max, 1)) + ",";
                lbllong.Text = string.Format("{0}", Math.Round(weatherinfo.coord.lon, 1)) + ",";
                lbllati.Text = string.Format("{0}m/s", Math.Round(weatherinfo.coord.lat, 1)) + ",";
                tblweather.Visible = true;
            }
        }
        public class Clouds
        {
            public int all { get; set; }
        }

        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public int sea_level { get; set; }
            public int grnd_level { get; set; }
        }

        public class Root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public string @base { get; set; }
            public Main main { get; set; }
            public int visibility { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public int dt { get; set; }
            public Sys sys { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }

        public class Sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }
    }
}