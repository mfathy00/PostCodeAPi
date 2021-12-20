using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostCodeAPi.Response; 

namespace PostCodeAPi.Services
{
    public class PostCodeSearch : IPostCodeSearch
    {
        public PostCodeViewcs test(string testcode)
        {
            var code = new  PostCodeViewcs();
            return code; 
        }
    }
}
