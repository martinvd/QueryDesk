﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryDesk
{
    class StoredQuery
    {
        protected string sqltext;
        public List<string> parameters = new List<string>();

        public string SQL
        {
            get { return sqltext; }
            set { sqltext = value; ParseParams(); }
        }

        protected void ParseParams()
        {
            parameters.Clear();

            var inparam = false;
            var paramname = "";

            var i = 0;
            var c = sqltext.Length;
            while (i < c)
            {
                // start of parameter with : or ?
                if ((sqltext[i] == ':') || (sqltext[i] == '?'))
                {
                    inparam = true;
                }
                else if (inparam && (char.IsLetterOrDigit(sqltext[i]) || sqltext[i] == '_'))
                {
                    // parameter name continues as long as theres an alphanum char or underscore
                    paramname += sqltext[i];
                }
                else if (inparam)
                {
                    // some other char, probably ending the parameter name
                    parameters.Add(paramname);
                    inparam = false;
                    paramname = "";
                }

                i++;
            }

            // if we're on the end of string and we haven't stored the last paramname yet
            if (inparam && (paramname != ""))
            {
                parameters.Add(paramname);
            }
        }

        public StoredQuery(string sql)
        {
            this.SQL = sql;
        }

        public override string ToString()
        {
            return this.SQL;
        }
    }
}