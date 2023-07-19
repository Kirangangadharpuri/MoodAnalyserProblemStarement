using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblem.MoodAnalyse_CustomException;

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
                //return "Happy";
                throw new MoodAnalyse_CustomException("message should not be null", MoodAnalyser_ExceptionType.NULL_MOOD);
            }
        }
    }
}
