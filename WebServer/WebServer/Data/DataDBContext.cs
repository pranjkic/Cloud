using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Data
{
    public class DataDBContext
    {
        public int GetNumOfConns()
        {
            using (var db = new ProjectDBContext())
            {
                db.Values.Find(1).Val++;
                int val = db.Values.Find(1).Val;
                db.SaveChanges();
                return val;
            }
        }
    }
}
