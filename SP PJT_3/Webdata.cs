using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_PJT_3
{
    class Webdata
    {
        [Required]
        [MaxLength(30)]
        public string Com_Name { get; set; }
        [MaxLength(30)]
        public string Price_now { get; set; }
        public string date_time { get; set; }
    }
}
