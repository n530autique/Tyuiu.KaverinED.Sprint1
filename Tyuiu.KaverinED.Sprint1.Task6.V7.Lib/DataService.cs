﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KaverinED.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string res = "";
            string[] subs = value.Split();
            if (value.Replace(" ", "") == "")
            {
                return "";
            }
            foreach (string sub in subs)
            {
                res += (sub.Substring(0, sub.Length - 1) + " ");
            }
            Regex trimmer = new Regex(@"\s\s+");
            res = trimmer.Replace(res, " ");
            return res.Trim();
        }
    }
}
