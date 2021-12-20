using PostCodeAPi.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostCodeAPi.Services
{
    public interface IPostCodeSearch
    {
        public PostCodeViewcs test(string testcode);

    }
}
