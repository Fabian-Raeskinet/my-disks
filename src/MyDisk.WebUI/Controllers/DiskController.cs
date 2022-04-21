using Microsoft.AspNetCore.Mvc;
using MyDisk.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDisk.WebUI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class DiskController : ControllerBase
    {

        private List<Disk> _disks;
        public DiskController()
        {
            _disks = new List<Disk>()
            {
                new Disk(){DiskId = "a1", Name = "Joli", ReleaseDate = DateTime.Now}
            };
        }

        [HttpGet]
        [Route("disks")]
        public IActionResult GetDisks()
        {
            return Ok(_disks);
        }
    }
}
