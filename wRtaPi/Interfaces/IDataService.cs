using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wRtaPi.Models;

namespace wRtaPi.Interfaces
{
    interface IDataService
    {
        List<WResource> GetAll();
        WResource GetById(long id);
    }
}
