﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace BIOM_ALYSSAR
{
    class Helper
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
        }
    }
}
