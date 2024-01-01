using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //track if the level is unlock
    public ClockAnimate ClockAnimate;
    private Player_progress progress;
    public Mainthread Mainthread;
    
    public void loadStart()
    {
        SceneManager.LoadScene(0);
    }
    // move to setting stage
    public void loadSetting()
    {
        SceneManager.LoadScene(1);
    }
    
    //move to level selection
    public void loadLevelSelection()
    {
        SceneManager.LoadScene(2);
    }
    
    // move to level one
    public void loadLevel1()
    {
        // load to level
        SceneManager.LoadScene(3);
    }
    
    // move to level two
    public void loadLevel2()
    {
        // load to level 2 if reach
        if (Mainthread.level2)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            // TBD Warning
            ClockAnimate.forbid = true;
            Debug.Log(1);
        }
    }
    //load end scene
    public void loadEnd()
    {
        SceneManager.LoadScene(5);
    }
}
