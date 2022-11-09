using UniRx;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Events")]
public class GameEvents : ScriptableObject
{
    public ISubject<string> LoadScene = new Subject<string>();

    public ISubject<(int, int)> Continue = new Subject<(int, int)>();//session y opp

    public ISubject<Unit> NewSession = new Subject<Unit>();

    public ISubject<int> Rematch = new Subject<int>();//idOpponent

    public ISubject<(int, int)> Results = new Subject<(int, int)>(); //idSession, idRound
}
