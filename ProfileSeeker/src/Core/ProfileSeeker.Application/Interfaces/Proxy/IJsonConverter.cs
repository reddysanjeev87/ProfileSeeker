/// <summary>
/// this is the proxy interface of newton soft json
/// </summary>
namespace ProfileSeeker.Application
{
    public interface IJsonConverter
    {
        /// <summary>
        /// THis is the generic method
        /// Will take input as string
        /// and convert into object of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        T Deserialize<T>(string item);

        /// <summary>
        /// This is the generic method
        /// wiil take input of type T
        /// and convert into string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        string Serialize<T>(T item);
    }
}
