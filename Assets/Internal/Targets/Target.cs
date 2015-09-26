using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

public class Target : MonoBehaviour
{

    private Vector2 targetCenter;
    private float distForGoodScore;

    private int goodScore, badScore;

    private GameObject bulletholePrefab;

    private SpriteRenderer renderer;
    protected Sprite backSprite;


    // Use this for initialization
    public virtual void Start()
    {
        bulletholePrefab = Resources.Load<GameObject>("BulletHole");

        renderer = GetComponent<SpriteRenderer>();
        Assert.IsNotNull(renderer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hit(Vector2 hitPos)
    {
        var bulletHole = Instantiate(bulletholePrefab);
        bulletHole.transform.position = hitPos;

        iTween.RotateBy(gameObject, iTween.Hash(
            "amount", new Vector3(0,3,0),
            "time", 3f,
            "easetype", iTween.EaseType.easeOutCubic,
            "oncomplete", "OnSpinFinish",
            "oncompletetarget", gameObject
            ));

        renderer.sprite = backSprite;
    }

    public virtual void OnSpinFinish()
    {
        var parentStick = GetComponentInParent<Stick>();
        Assert.IsNotNull(parentStick);

        parentStick.StartDropping();
    }
}
