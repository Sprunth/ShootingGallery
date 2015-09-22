using UnityEngine;
using System.Collections;

public class DuckTarget : Target
{

    // Use this for initialization
    public override void Start()
    {
        backSprite = Resources.Load<Sprite>("Objects/duck_outline_back");

        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
