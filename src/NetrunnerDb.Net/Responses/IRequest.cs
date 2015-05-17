using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetrunnerDb.Net
{
    public interface IRequest
    {
        string EndPoint(string parameter = "");
    }
}
