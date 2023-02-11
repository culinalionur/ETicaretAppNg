using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQueryResponse
    {
        public int TotalProducts { get; set; }
        public object Products { get; set; }
    }
}
