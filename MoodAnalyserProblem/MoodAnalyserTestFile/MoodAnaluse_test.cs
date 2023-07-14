using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyserProblem;

namespace MoodAnalyserTestFile
{
    public class MoodAnaluse_test
    {
        MoodAnalyse moodAnalyse = new MoodAnalyse();
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyse.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenAnyMood_ShouldReturnHappy()
        {
            string result = moodAnalyse.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(result, "Happy");
        }
    }
}

