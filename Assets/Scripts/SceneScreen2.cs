using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SceneScreen2 : MonoBehaviour
{
    public GameEvents GameEvents;
    public Button Button;

    public GameObject IdSession;
    public GameObject IdRound;

    void Start()
    {
        var observableButton = Button.OnClickAsObservable();
        observableButton.Subscribe(x => Navegate());

    }

    public void Navegate()
    {
        int idSession = Int32.Parse(IdSession.GetComponent<Text>().text);
        int idRound = Int32.Parse(IdRound.GetComponent<Text>().text);

        GameEvents.LoadScene.OnNext("scene3");///resultados
        GameEvents.Results.OnNext((idSession, idRound));
    }

}
