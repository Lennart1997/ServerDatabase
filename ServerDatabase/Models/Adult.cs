using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;

namespace RestServer.Data
{
    public class Adult : Person
    {
        private IList<Adult> adults;
        
        public string JobTitle { get; set; }
        public int Salary { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        
        
    }
}