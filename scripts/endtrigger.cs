using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager Gamemanager;
   void OnTriggerEnter ()
    {
        Gamemanager.CompleteLevel();
    }
}
