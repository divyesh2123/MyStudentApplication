using StudentManagementSystem.DataEnitny;
using StudentManagementSystem.Repositroy.Interface;
using StudentManagementSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Service.Concreate
{
    public class CityMasterService : ICityMasterService
    {
        private ICityMasterRepositroy cityMasterRepositroy { get; set; }
        public CityMasterService(ICityMasterRepositroy _cityMasterRepositroy)
        {

            cityMasterRepositroy = _cityMasterRepositroy;
        }

        public List<CityMaster> GetCityMasters()
        {
            return cityMasterRepositroy.GetCityMasters();
        }
    }
}
