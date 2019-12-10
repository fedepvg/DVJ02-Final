using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string ThisScene;
    public string NextScene;
    public string GameOverScene;
    public string MenuScene;
    
    public string PreviousScene;

    private void Start()
    {
        PreviousScene = LoaderManager.Instance.ActualScene;
        LoaderManager.Instance.ActualScene = ThisScene;
        LoaderManager.Instance.SceneData = this;
        GameManager.Instance.SceneLoader = this;
    }

    public void ReloadScene()
    {
        LoaderManager.Instance.LoadScene(ThisScene);
    }

    public void LoadNextScene()
    {
        LoaderManager.Instance.LoadScene(NextScene);
    }

    public void LoadPreviousScene()
    {
        LoaderManager.Instance.LoadScene(PreviousScene);
    }

    public void LoadMenuScene()
    {
        LoaderManager.Instance.LoadScene(MenuScene);
    }

    public void LoadGOScene()
    {
        LoaderManager.Instance.LoadScene(GameOverScene);
    }
    
    public void LoadTargetScene(string target)
    {
        LoaderManager.Instance.LoadScene(target);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
        Application.Quit ();
#endif
    }
}
