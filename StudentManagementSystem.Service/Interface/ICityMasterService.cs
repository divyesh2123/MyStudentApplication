using StudentManagementSystem.DataEnitny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Service.Interface
{
    public interface ICityMasterService 
    {
        List<CityMaster> GetCityMasters();
    }
}
