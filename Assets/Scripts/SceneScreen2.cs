using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SceneScreen2 : MonoBehaviour
{
    public GameEvents GameEvents;
    public Button Button;

    void Start()
    {
        var observableButton = Button.OnClickAsObservable();
        observableButton.Subscribe(x => Navegate());

    }

    public void Navegate()
    {
        GameEvents.LoadScene.OnNext("scene3");
    }
}
