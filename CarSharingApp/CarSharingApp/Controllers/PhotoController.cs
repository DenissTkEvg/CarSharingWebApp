using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public PhotoController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [ResponseCache(VaryByHeader = "Last-Modified", Duration = 30)]
        public FileResult GetCarPhoto(string filename)
        {
            string full_file_name = _env.WebRootPath+"\\"+"img"+"\\"+filename;
            return PhysicalFile(full_file_name, "image/jpeg");
        }
    }
}
