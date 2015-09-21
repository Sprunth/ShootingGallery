using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{

    private Vector2 targetCenter;
    private float distForGoodScore;

    private int goodScore, badScore;

    private GameObject bulletholePrefab;

    // Use this for initialization
    void Start()
    {
        bulletholePrefab = Resources.Load<GameObject>("BulletHole");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hit(Vector2 hitPos)
    {
        var bulletHole = Instantiate(bulletholePrefab);
        bulletHole.transform.position = hitPos;
    }
}
