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

    void Update()
    {
        if (sceneNum == 1)
        {
            // level one
            if (Texttonumber() == 0)
            {
                progress.progress[0] = true;
                DontDestroyOnLoad(progress);
                GameManager.loadLevelSelection();
                // unlock the next level
                // move back to the original scene
            }
        }
        else
        {
            // level two
            if (Texttonumber() == 0)
            {
                //GameManager.level3Unlock = true;
                GameManager.loadLevelSelection();
            }
        }
    }

    public int Texttonumber()
    {
        return Int32.Parse(text0.text)+Int32.Parse(text1.text)+Int32.Parse(text2.text)+Int32.Parse(text3.text);
    }
    
    
}
