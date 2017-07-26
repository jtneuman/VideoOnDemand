using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoOnDemand.Models.DTOModels
{
    public class DownloadDTO
    {
        public string DownloadUrl { get; set; }  //switched type from int to string to try to fix null ref exception
        public string DownloadTitle { get; set; }  //NOTE:  correcting DownloadUrl from int to string type corrected null ref error.

    }
}


