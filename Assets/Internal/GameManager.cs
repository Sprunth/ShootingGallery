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
        var hit = Physics2D.Raycast(cam.transform.position, shotPos);

        if (hit && hit.collider)
        {
            var targetCom = hit.collider.gameObject.GetComponent<Target>();
            if (targetCom != null)
            {
                targetCom.Hit(shotPos);
            }
        }
    }
}
