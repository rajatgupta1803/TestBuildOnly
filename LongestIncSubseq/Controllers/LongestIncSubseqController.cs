using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LongestIncSubseqApi.Controllers
{
    public class LongestIncSubseqController : Controller
    {
        private readonly ILogger<LongestIncSubseqController> _logger;
        private string newline;
        public LongestIncSubseqController()
        {
        }

        public LongestIncSubseqController(ILogger<LongestIncSubseqController> logger)
        {
            _logger = logger;
        }

        
        [HttpPost]
        public string GetLongestIncSubseq([FromBody] string inputValues)
        {
            LongestIncSubseq objLongIncSubseq = new LongestIncSubseq();
            // Validating the User input for Digits and spaces only
            Regex rgx = new Regex(@"^[\d\s]+$");
            
            if (!String.IsNullOrEmpty(inputValues) && rgx.IsMatch(inputValues))
            {
               

                int[] line = Array.ConvertAll<string, int>(inputValues.ToString().Split(' '), Convert.ToInt32);
                if (line != null)
                {
                    objLongIncSubseq.Solve(line);
                    if (objLongIncSubseq.output != null)
                        newline=String.Join(" ", objLongIncSubseq.output);
                }
            }
            return  newline;
        }
    }
}
    

