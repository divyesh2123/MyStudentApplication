using StudentManagementSystem.DataEnitny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Repositroy.Interface
{
    public interface ICityMasterRepositroy
    {
        List<CityMaster> GetCityMasters();
    }
}
