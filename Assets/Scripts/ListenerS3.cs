using UniRx;
using UnityEngine;

public class ListenerS3 : MonoBehaviour
{

    public GameEvents GameEvents;

    void Start()
    {
        GameEvents.Results.Subscribe(value => Results(value)).AddTo(this);
    }

    public void Results((int, int) value)
    {
        Debug.Log("show results: " + value.Item1 + " - " + value.Item2);
    }
}
