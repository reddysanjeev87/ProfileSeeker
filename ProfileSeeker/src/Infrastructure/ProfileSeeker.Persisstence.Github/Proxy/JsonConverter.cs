using Newtonsoft.Json;
using ProfileSeeker.Application;

namespace ProfileSeeker.Persisstence.Github
{
    /// <summary>
    /// Members are explicitly implemented
    /// so that only interface members are public
    /// and class members are private
    /// </summary>
    public class JsonConverter : IJsonConverter
    {
        T IJsonConverter.Deserialize<T>(string item)
        {
            return JsonConvert.DeserializeObject<T>(item);
        }

        string IJsonConverter.Serialize<T>(T item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
