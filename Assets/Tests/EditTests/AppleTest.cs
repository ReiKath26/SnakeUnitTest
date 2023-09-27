using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using Snake;

public class AppleTest
{

    public AppleManager appleManager = new AppleManager();
    [Test]
    public void ShouldSpawnApple()
    {
        GameObject obj = appleManager.SpawnApple();
       
        Assert.GreaterOrEqual(obj.transform.position.x, -10.0f);
        Assert.GreaterOrEqual(obj.transform.position.y, -5.0f);
        Assert.LessOrEqual(obj.transform.position.x, 9.0f);
        Assert.LessOrEqual(obj.transform.position.y, 5.0f);
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
