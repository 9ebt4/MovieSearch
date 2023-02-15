using Newtonsoft.Json;
using System.Net;

namespace Searching_OMDB.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovieModel(string name)//adjust here
        {
            //adjust here
            //setup
            string key = "d807eeb2";
            string url = $"https://www.omdbapi.com/?t={name}&apikey={key}";
            //request
            WebRequest request = WebRequest.CreateHttp(url);
            WebResponse response = (HttpWebResponse)request.GetResponse();
            //convert to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();
            //adjust here
            //Convert to C#
            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return result;
        }
    }
}
