namespace NetrunnerDb.Net.Responses
{
    public abstract class BaseRequest : IRequest
    {
        public virtual bool IsArray { get { return true; }}
        public abstract string EndPoint(string parameter = "");
    }
}
