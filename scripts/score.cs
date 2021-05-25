
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform mainplayer;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = mainplayer.position.z.ToString("0");
        
    }
}
