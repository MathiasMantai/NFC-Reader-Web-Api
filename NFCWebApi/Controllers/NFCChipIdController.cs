using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace NFCWebApi.Controllers
{
    public class NFCChipIdController : ApiController
    {
        [HttpGet]
        public IEnumerable<Models.NFCChip> getNFCChipId()
        {
            return new Models.NFCChip[]
            {
                new Models.NFCChip {NFCChipId = 12312}
            };
        }
    }
}