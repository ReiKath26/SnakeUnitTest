using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using Snake;

public class SnakeTest
{
    public SnakeManager snakeManager = new SnakeManager();

    [Test]
    public void ShouldSpawnInitialSnek()
    {
        GameObject obj = snakeManager.InitialSpawn();

        Assert.AreEqual(new Vector3(9, -0.2f, -2), obj.transform.position);
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
