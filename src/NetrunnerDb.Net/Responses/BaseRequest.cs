using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerDb.Net.Responses
{
    public abstract class BaseRequest : IRequest
    {
        public virtual bool IsArray { get { return true; }}
        public abstract string EndPoint(string parameter = "");
    }
}
