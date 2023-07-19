using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    //Custom exception are user 
    public class MoodAnalyse_CustomException:Exception
    {
        public enum MoodAnalyser_ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
        }
        public MoodAnalyser_ExceptionType type;
        // Base keyword is used to access member of base class within derived class.
        public MoodAnalyse_CustomException(string message,MoodAnalyser_ExceptionType type):base(message)
        {
            this.type = type;
        }
    }
}
