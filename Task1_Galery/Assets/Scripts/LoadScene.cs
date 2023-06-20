using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScene : MonoBehaviour
{
    [SerializeField] GameObject _loadingScreen;

    [SerializeField] Slider _progresBar;

    [SerializeField] TextMeshProUGUI _progresCountText;

    public void Load(int _sceneBuildIndex)
    {
        _loadingScreen.SetActive(true);

        StartCoroutine(LoadSceneAsync(_sceneBuildIndex));
    }

    IEnumerator LoadSceneAsync(int _sceneIndex)
    {
        AsyncOperation asyncload = SceneManager.LoadSceneAsync(_sceneIndex);
        asyncload.allowSceneActivation = false;

        while (!asyncload.isDone)
        {
            _progresBar.value = asyncload.progress;
            _progresCountText.text = $"{asyncload.progress*100}%";

            if(asyncload.progress >=.9f && !asyncload.allowSceneActivation)
            {
                yield return new WaitForSeconds(3f);
                asyncload.allowSceneActivation =true;
            }
            yield return null;
        }
    }
}
