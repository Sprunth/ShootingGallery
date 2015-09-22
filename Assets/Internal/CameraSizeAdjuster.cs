using UnityEngine;
using System.Collections;

public class CameraSizeAdjuster : MonoBehaviour
{
    private Camera cam;
    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();

        var aspectRatio = (1f*Screen.width)/Screen.height;

        /*
         * Size 5 is to 16:10
         * Size X is to w/h
         */

        cam.orthographicSize = 5 + (5-(5 * aspectRatio) / (16f / 10));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
