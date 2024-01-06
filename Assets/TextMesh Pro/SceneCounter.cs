using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SceneCounter : MonoBehaviour
{
    public int sceneNum;
    public TextMeshProUGUI text0;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public Player_progress progress;
    public GameManager GameManager;

    public delegate void ProgressUpdate();

    public static ProgressUpdate level1Delegate;
    public static ProgressUpdate level2Delegate;
    public static ProgressUpdate level3Delegate;
    public ProgressUpdate level4Delegate;
    public ProgressUpdate level5Delegate;
    void Update()
    {
        switch (sceneNum)
        {
            case 1:
                // level one
                if (Texttonumber() == 0)
                {
                    //level1Delegate?.Invoke();
                    progress.progress[0] = true;
                    DontDestroyOnLoad(progress);
                    GameManager.loadLevelSelection();
                    // unlock the next level
                    // move back to the original scene
                }
                break;
            
            case 2:
                if (Texttonumber() == 0)
                {
                    //level2Delegate?.Invoke();
                    //GameManager.level3Unlock = true;
                    GameManager.loadLevelSelection();
                }
                break;
            
            default:
                throw new NullReferenceException("invalid level selection");
                break;
                
        }
    }

    public int Texttonumber()
    {
        return Int32.Parse(text0.text)+Int32.Parse(text1.text)+Int32.Parse(text2.text)+Int32.Parse(text3.text);
    }
    
    
}
