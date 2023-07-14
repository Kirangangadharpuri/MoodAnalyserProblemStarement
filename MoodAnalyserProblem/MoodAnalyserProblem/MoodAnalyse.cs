﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyse
    {
        string message;
        public MoodAnalyse(string message) 
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {


                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                return "Happy";

            }
        }
    }
}
