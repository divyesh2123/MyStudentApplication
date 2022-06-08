using Microsoft.Extensions.Configuration;
using StudentManagementSystem.DataEnitny;
using StudentManagementSystem.Repositroy.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Repositroy.concreate
{
    public class CityMasterRepositroy : ICityMasterRepositroy
    {
        public SqlConnection con;

        private IConfiguration _config;

        public CityMasterRepositroy(IConfiguration config)
        {
            string constr = _config.getco;
            con = new SqlConnection(constr);
        }

        public List<CityMaster> GetCityMasters()
        {
            List<CityMaster> EmpList = new List<CityMaster>();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Select * from CityMaster", con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();
            da.Fill(dt);
            con.Close();


            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(

                    new CityMaster
                    {

                        CityID = Convert.ToInt32(dr["CityID"]),
                        CityName = Convert.ToString(dr["CityName"]),


                    }
                    );
            }










            return EmpList;

        }
    }
}
