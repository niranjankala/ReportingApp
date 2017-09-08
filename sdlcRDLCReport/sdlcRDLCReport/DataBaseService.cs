using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdlcRDLCReport
{
    public class DataBaseService
    {
        private SMR_KMS_DB_DevEntities _context = new SMR_KMS_DB_DevEntities();

        public DataTable RDLCMemmory()
        {
            KMTeams dbPlant = new KMTeams();
            DataTable dt = new DataTable();
            var properties = typeof(KMTeams).GetProperties();


            dt.Columns.Add("TeamName", typeof(System.String));
            dt.Columns.Add("CreatedOn", typeof(System.String));

            _context.KMTeams.ToList().ForEach(onj =>
            {
                DataRow dr = dt.NewRow();
                dr["TeamName"] = onj.TeamName;
                dr["CreatedOn"] = onj.CreatedOn;
                dt.Rows.Add(dr);
            });

            return dt;
        }
    }
}
