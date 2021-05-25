
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform mainplayer;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = mainplayer.position + offset;
    }
}
