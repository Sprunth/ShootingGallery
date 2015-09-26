using UnityEngine;
using System.Collections;

public class Stick : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Start the process of dropping off the screen
    /// Typically called by the child target after it has been hit
    /// </summary>
    public void StartDropping()
    {
        iTween.MoveBy(gameObject, iTween.Hash(
            "amount", new Vector3(0,-5),
            "time", 3,
            "easetype", iTween.EaseType.easeOutExpo,
            "oncompletetarget", gameObject,
            "oncomplete", "OnFinishDropping"
            ));
    }

    public void OnFinishDropping()
    {
        Destroy(gameObject);
    }
}
