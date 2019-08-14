using System;
using System.Collections.Generic;
using System.Text;

namespace Args_tdd_sample
{
   public class ParamSchema
    {
        public string Flag { get; set; }
        public string Type { get; set; }
        public object Default { get; set; }
    }

   public class Param
   {
       public string Flag { get; set; }
       public object Value { get; set; }
        public string errMsg { get; set; }
   }

}
