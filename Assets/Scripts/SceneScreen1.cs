using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SceneScreen1 : MonoBehaviour
{
    public GameEvents GameEvents;
    public Button Button;
    public Button ButtonNewSession;
    public Button ButtonNewRound;
    public Button ButtonRematch;


    public GameObject IdSession;
    public GameObject IdRound;
    public GameObject IdOpponent;
    public GameObject IdPlayer;


    void Start()
    {
        //button comun
        var observableButton = Button.OnClickAsObservable();
        observableButton.Subscribe(x => Navegate());
        //new session
        var observableNewSession = ButtonNewSession.OnClickAsObservable();
        observableNewSession.Subscribe(x => Navegate());
        //new round-continue game
        var observableNewRound = ButtonNewRound.OnClickAsObservable();
        observableNewRound.Subscribe(x => Countinue());

        //rematch
        var observableRematch = ButtonRematch.OnClickAsObservable();
        observableRematch.Subscribe(x => Rematch());
    }

    public void Navegate()
    {
        GameEvents.LoadScene.OnNext("scene2");
    }

    public void Countinue()
    {
        Navegate();
        int idSession = System.Int32.Parse(IdSession.GetComponent<Text>().text);
        int idOpponent = System.Int32.Parse(IdOpponent.GetComponent<Text>().text);
        GameEvents.Continue.OnNext((idSession, idOpponent));
    }

    public void Rematch()
    {
        Navegate();
        int idOpponent = System.Int32.Parse(IdOpponent.GetComponent<Text>().text);
        GameEvents.Rematch.OnNext(idOpponent);

    }
}
