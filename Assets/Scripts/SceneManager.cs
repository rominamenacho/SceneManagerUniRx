using UniRx;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameEvents GameEvents;
    public GameObject SceneScreen;
    public string SceneName;

    void Start()
    {
        GameEvents.LoadScene
            .Subscribe(sceneName => HandlerScene(sceneName))
            .AddTo(this);
    }


    void HandlerScene(string sceneName)
    {
        if (SceneName == sceneName)
        {
            SceneScreen.SetActive(true);
        }
        else
        {
            SceneScreen.SetActive(false);
        }

    }
}
