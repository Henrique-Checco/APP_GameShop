using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Data
{
    public interface ISQLiteDB
    {
        string SQLiteLocalPath(string bancoDados);
    }
}
