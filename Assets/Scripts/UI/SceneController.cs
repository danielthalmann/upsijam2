using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Animator sceneTransition;

    public void LoadScene(string scene)
    {
        StartCoroutine(EnumEffect(scene));
    }

    protected IEnumerator EnumEffect(string scene)
    {
        Time.timeScale = 1.0f;
        // start animator
        sceneTransition.SetTrigger("start");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(scene);
    }
}
