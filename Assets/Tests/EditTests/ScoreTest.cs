using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using Snake;

public class ScoreTest
{

    public HighScoreManager _scoreManager = new HighScoreManager();

    [Test]
    public void ShouldAddScore()
    {
        for(int i=0;i<5;i++)
        {
            _scoreManager.AddScore();
        }

        Assert.AreEqual(5, _scoreManager.GetScore());
    }

    [Test]
    public void ShouldResetScore()
    {
        _scoreManager.ResetScore();

        Assert.AreEqual(0, _scoreManager.GetScore());
    }

    //// A Test behaves as an ordinary method
    //[Test]
    //public void ScoreTestSimplePasses()
    //{
    //    // Use the Assert class to test conditions
    //}

    //// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    //// `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator ScoreTestWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}
}
