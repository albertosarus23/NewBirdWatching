using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_progress : MonoBehaviour
{
    public bool[] progress = new bool[2];

    private void OnEnable()
    {
        SceneCounter.level1Delegate += level1Unlock;
    }

    public void level1Unlock()
    {
        throw new NotImplementedException();
    }
}
