using UniRx;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Events")]
public class GameEvents : ScriptableObject
{
    public ISubject<string> LoadScene = new Subject<string>();
}
