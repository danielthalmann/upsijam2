using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject menuPanel;
    public SceneController sceneLoader;
    private bool opened;
    public string sceneStart;

    // Start is called before the first frame update
    void Start()
    {
        CloseMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            ToggleMenu();

    }

    /// <summary>
    /// Toggle menu
    /// </summary>
    public void ToggleMenu()
    {
        if (!opened)
            OpenMenu();
        else
            CloseMenu();
    
    }

    /// <summary>
    /// Open the menu
    /// </summary>
    public void OpenMenu()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
        opened = true;
    }
    
    /// <summary>
    /// Close the menu
    /// </summary>
    public void CloseMenu()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);
        opened = false;
    }
    
    /// <summary>
    /// Exit scene
    /// </summary>
    public void Exit()
    {
        Debug.Log(sceneStart);
          sceneLoader.LoadScene(sceneStart);
    }

}
