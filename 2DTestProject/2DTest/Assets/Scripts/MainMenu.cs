using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string startStage;
    bool is_saved = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!is_saved)
        {
            startStage = "Game1";
        }
        else
        {
            //startStage = savedStage;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickedStart()
    {   
        Debug.Log("새로운 씬 불러오기");

        GameManager.instance.LoadScene(startStage);
    }

    public void OnClickedQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Aplication.Quit();
#endif
    }

}
