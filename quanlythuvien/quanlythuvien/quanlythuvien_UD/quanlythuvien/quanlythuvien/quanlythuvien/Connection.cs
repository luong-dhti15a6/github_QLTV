using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuvien
{
    internal class Connection
    {

        public string ConnectionString()
        {
            string str = "Data Source=LAPTOP-OPLQRNCV\\SQL;Initial Catalog=QLTV;Integrated Security=True";
            return str;
        }
    }
}
