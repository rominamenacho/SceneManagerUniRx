using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ListenersS2 : MonoBehaviour
{
    public GameEvents GameEvents;

    public Button ButtonNewRound;
    public Button ButtonNewSession;

    void Start()
    {

        var observableButtonNewSession = ButtonNewSession.OnClickAsObservable();
        observableButtonNewSession.Subscribe(x => NewSession());


        GameEvents.Continue.Subscribe(value => NewRound(value)).AddTo(this);

        GameEvents.Rematch.Subscribe(x => Rematch(x)).AddTo(this);
    }


    public void NewSession()
    {
        Debug.Log("Soy new Session. Estoy en el listener de la escena2. como ejecuto este metodo desde el mono de la vista? ");
    }

    public void NewRound((int, int) value)
    {
        Debug.Log("Soy new Round" + value.Item1 + " - " + value.Item2);
    }

    public void Rematch(int idOpponent)
    {
        Debug.Log("Soy Rematch" + idOpponent);
    }
}
