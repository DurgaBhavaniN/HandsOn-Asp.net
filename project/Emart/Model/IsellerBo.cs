using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Model
{
    public interface IsellerBo
    {
         Seller Search_Id(int s_id);
        List<Seller> DisplayDetails();
    }
}
