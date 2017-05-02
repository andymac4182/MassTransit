namespace System.Net.Mime
{
    public class ContentType
    {
        public ContentType(string mediaType)
        {
            MediaType = mediaType;
        }

        public string MediaType { get; private set; }
    }
}