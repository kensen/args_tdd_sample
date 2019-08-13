using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Args_tdd_sample
{
   public  class  Parser
   {
       private List<ParamSchema> _schemaList;

        public Parser()
        {
            _schemaList = new List<ParamSchema>();
            _schemaList.Add(new ParamSchema() { Flag = "l", Type = typeof(bool), Default = true });
        }

        public  List<Param> GetParam(string testString)
        {
            var pList = testString.Split("-");
            List<Param> @params = new List<Param>();

            foreach (var item in pList)
            {
                var p = item.Split(" ");
                Param newParam = new Param();
                newParam.Flag = p[0];
                if (p.Length > 1)
                {
                    newParam.Value =p[1];
                }

                @params.Add(newParam);
            }


            return null;

        }
    }
}
