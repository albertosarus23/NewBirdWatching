using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But_function : MonoBehaviour
{
    public GameManager GameManager;
    public ClockAnimate clockAnimate;
    
    // press this but to go to start scene
    public void start_scene()
    {
        GameManager.loadStart();
    }
    // start button
    public void start_game()
    {
        GameManager.loadLevelSelection();
    }
    
    // settings button
    public void settings()
    {
        GameManager.loadSetting();
    }

    // press this but to go to level1
    public void start_level1()
    {
        clockAnimate.level1 = true;
        StartCoroutine(WaitForSeconds(1));
    }
    
    // press this but to go to level2
    public void start_level2()
    {
        clockAnimate.level2 = true;
        StartCoroutine(WaitForSeconds(2));
    }
    IEnumerator WaitForSeconds(int level)
    {
        yield return new WaitForSeconds(level*2);
        switch (level)
        {
            case 1:
                GameManager.loadLevel1();
                Debug.Log(1);
                break;
            case 2:
                GameManager.loadLevel2();
                break;
        }
    }
}
