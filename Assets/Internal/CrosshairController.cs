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

        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            accelDiff = (Input.mousePosition - new Vector3(Screen.width/2f, Screen.height/2f));
            accelDiff.Scale(new Vector3(1f/Screen.width, 1f/Screen.height));
        }

        transform.Translate(accelDiff.x, accelDiff.y, 0);

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // todo: ammo

            gameMgr.RegisterShot(transform.position);
        }

        if (Application.platform == RuntimePlatform.WindowsEditor && Input.GetMouseButtonDown(0))
        {
            gameMgr.RegisterShot(transform.position);
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
