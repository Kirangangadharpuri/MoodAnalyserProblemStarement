﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyserProblem;

namespace MoodAnalyserTestFile
{
    public class MoodAnaluse_test
    {
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");

            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }

        [Test]
        public void GivenHappyMood_ShouldReturnHappy()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Happy Mood");

            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}

