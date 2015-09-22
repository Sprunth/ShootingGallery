using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private Camera cam;

    // Use this for initialization
    void Start()
    {
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterShot(Vector2 shotPos)
    {
        //var shotPosWorldPoint = cam.ScreenToWorldPoint(shotPos);
        //var hit = Physics2D.Raycast(shotPosWorldPoint, Vector2.zero, 100f);

        var coll = Physics2D.OverlapPoint(shotPos);

        if (coll != null)
        {
            var targetCom = coll.gameObject.GetComponent<Target>();
            if (targetCom != null)
            {
                targetCom.Hit(shotPos);
            }
        }
    }
}
