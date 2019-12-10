using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoaderManager : MonoBehaviourSingleton<LoaderManager>
{
    string LoadedScene;
    public SceneLoader SceneData;
    
    public void LoadScene(string target)
    {
        SceneManager.LoadScene(target);
    }

    public string ActualScene
    {
        get { return LoadedScene; }
        set { LoadedScene = value; }
    }
}