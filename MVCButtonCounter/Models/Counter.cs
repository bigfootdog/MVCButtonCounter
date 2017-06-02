using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCButtonCounter.Tools;

namespace MVCButtonCounter.Models
{

    public class Counter
    {
        public int count { get; set; }

        public Counter()
        {
            var result = new DataProcessor().ExecuteScalar("SELECT MAX([count]) FROM counter");
            this.count = (DBNull.Value.Equals(result)) ? 0 : Convert.ToInt32(result);
        }

        public void incrementCounter()
        {
            if (!(this.count < 10)) { return; }

            string sqlCommand = (this.count == 0) ? "INSERT INTO [dbo].[counter] (count) VALUES ({0})"
                : "UPDATE [dbo].[counter] SET count = {0}";

            this.count++;

            new DataProcessor().ExecuteNonQuery(string.Format(sqlCommand, this.count));
        }

    }
}