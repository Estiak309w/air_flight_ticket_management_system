using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;


namespace air
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE; User ID =airflight;Password=airflight;");
    }
}
