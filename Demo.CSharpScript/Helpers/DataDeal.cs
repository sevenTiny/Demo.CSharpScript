﻿using Demo.CSharpScript.Models;
using System.Collections.Generic;

namespace Demo.CSharpScript.Helpers
{
    public class DataDeal
    {
        public static string Before(string name)
        {
            return name;
        }

        public static List<DemoModel> After(List<DemoModel> models)
        {
            return models;
        }
    }
}
