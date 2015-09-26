using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

public class DuckTarget : Target
{
    public enum DuckType
    {
        Brown, White, Yellow
    }

    public DuckType DType;

    // Use this for initialization
    public override void Start()
    {
        var spriteCom = GetComponent<SpriteRenderer>();
        Assert.IsNotNull(spriteCom);
        switch (DType)
        {
            case DuckType.Brown:
                spriteCom.sprite = Resources.Load<Sprite>("Objects/duck_outline_target_brown");
                break;
            case DuckType.White:
                spriteCom.sprite = Resources.Load<Sprite>("Objects/duck_outline_target_white");
                break;
            case DuckType.Yellow:
                spriteCom.sprite = Resources.Load<Sprite>("Objects/duck_outline_target_yellow");
                break;
            default:
                throw new Exception("Unkwown duck type.");
        }

        backSprite = Resources.Load<Sprite>("Objects/duck_outline_back");

        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
