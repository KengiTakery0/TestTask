using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreenObject;

    private void Start()
    {
        _loadingScreenObject.SetActive(false);    
    }

    public void EnterGalery(int _sceneBuildIndex)
    {
        LoadScene _loadingScreen = _loadingScreenObject.GetComponent<LoadScene>();
        _loadingScreen.Load(_sceneBuildIndex);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
