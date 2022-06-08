using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.DataEnitny;
using StudentManagementSystem.Service.Interface;

namespace MyStudentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityMasterController : ControllerBase
    {

        private  ICityMasterService  cityMasterService {get; set;}

        

        public CityMasterController(ICityMasterService _cityMasterService)
        {
            cityMasterService = _cityMasterService;


        }
        [HttpGet]
        public List<CityMaster> Get()
        {

            return cityMasterService.GetCityMasters();
          
        }
    }
}
