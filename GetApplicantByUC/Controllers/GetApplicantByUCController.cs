using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetApplicantByUC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace GetApplicantByUC.Controllers
{
    [Route("api/GetApplicantByUC")]
    public class GetApplicantByUCController : Controller
    {
        private DatabaseContext _context;

        public GetApplicantByUCController(DatabaseContext context)
        {
            _context = context;
        }

        // GET api/GetApplicantByUC
        [HttpGet]
        public string Get(string UC)
        {
            string strUniqueCode = GetApplicant(UC);
            return strUniqueCode;
        }

        // POST api/GetApplicantByUC
        [HttpPost]
        public string Post([FromBody]Applicant applicant)
        {
            string strApplicantData = GetApplicant(applicant.appUniqueCode);

            return strApplicantData;
        }


        private string GetApplicant(string strUniqueCode)
        {
            string strApplicants = string.Empty;
            using (_context)
            {
                var applicant = _context.Applicants.FirstOrDefault(c => c.appUniqueCode == strUniqueCode);
                JsonSerializer serializer = new JsonSerializer();
                var json = JsonConvert.SerializeObject(applicant);
                strApplicants = json;
            }

            return strApplicants;
        }
    }

}
