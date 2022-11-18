using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    public SceneController sceneLoader;
    public string LevelStart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    /// <summary>
    /// Close the menu
    /// </summary>
    public void GameStart()
    {
        sceneLoader.LoadScene(LevelStart);
    }
    
    /// <summary>
    /// Exit scene
    /// </summary>
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
