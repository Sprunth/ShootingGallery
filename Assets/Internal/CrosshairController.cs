using UnityEngine;
using System.Collections;

public class CrosshairController : MonoBehaviour
{
    private GameManager gameMgr;
    private Vector3 callibration;

    // Use this for initialization
    void Start()
    {
        gameMgr = FindObjectOfType<GameManager>();

        callibration = Input.acceleration;
    }

    // Update is called once per frame
    void Update()
    {
        var accelDiff = callibration - Input.acceleration;

        transform.Translate(accelDiff.x, accelDiff.y, 0);

        if (Input.touchCount == 1)
        {
            // todo: ammo

            gameMgr.RegisterShot(Input.GetTouch(0).position);
        }

        // keep crosshairs in bounds
        if (transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
            callibration = new Vector3(transform.position.x - -6, callibration.y, callibration.z);
        }
        if (transform.position.x > 6)
        {
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
            callibration = new Vector3(transform.position.x - 6, callibration.y, callibration.z);
        }
        if (transform.position.y > 3)
        {
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
            callibration = new Vector3(callibration.x, transform.position.y - 3, callibration.z);
        }
        if (transform.position.y < -2)
        {
            transform.position = new Vector3(transform.position.x, -2, transform.position.z);
            callibration = new Vector3(callibration.x, transform.position.y - -2, callibration.z);
        }
    }
}
