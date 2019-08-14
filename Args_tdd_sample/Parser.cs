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
       private string _cmdLine;
        public Parser(string cmdLine)
        {
            _cmdLine = cmdLine;
            _schemaList = new List<ParamSchema>();
            _schemaList.Add(new ParamSchema() { Flag = "l", Type = "System.Boolean", Default = true });
            _schemaList.Add(new ParamSchema() { Flag = "p", Type = "System.Int32", Default = 0 });
            _schemaList.Add(new ParamSchema() { Flag = "d", Type = "System.String", Default = "" });
        }

        public Param GetParam( string flag)
        {
            ParamSchema schema = _schemaList.FirstOrDefault(a => a.Flag == flag);
            Param result = new Param();
            result.Flag = flag;
            var pStr = _cmdLine.Split("-").FirstOrDefault(a => a.Contains(flag));

            if (schema == null)
            {
                result.Value = "未定义该标记！";
            }

            var p= pStr.Split(" ");
            if (p.Length > 1)
            {
                Type t = Type.GetType(schema.Type);
                result.Value = p[1].Length>0?Convert.ChangeType(p[1],t):schema.Default;
            }
            else
            {
                result.Value = schema.Default;
            }
            
            return result;

        }
    }
}
