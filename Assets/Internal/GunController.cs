using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

public class GunController : MonoBehaviour
{
    private Sprite gunSpr;
    private GameObject crosshair;

    // Use this for initialization
    void Start()
    {
        gunSpr = GetComponent<SpriteRenderer>().sprite;
        Assert.IsNotNull(gunSpr);

        crosshair = FindObjectOfType<CrosshairController>().gameObject;
        Assert.IsNotNull(crosshair);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(crosshair.transform.position.x/2, transform.position.y, transform.position.z);

        var flip = transform.position.x >= 0;

        // make thinner as closer to center
        var newXscale = flip ? -1 : 1;

        transform.localScale = new Vector3(newXscale, 1, 1);


        var flipMod = flip ? 1 : -1;
        transform.rotation = Quaternion.AngleAxis(flipMod*2*(crosshair.transform.position.y-2), Vector3.forward);
    }
}
