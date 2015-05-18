namespace NetrunnerDb.Net.Responses
{
    public interface IRequest
    {
        bool IsArray { get; }
        
        string EndPoint(string parameter = "");
    }
}
