using UnityEngine;
using System.Collections;

public class BulletHoleController : MonoBehaviour
{
    private float startingTime;

    private SpriteRenderer renderer;

    // Use this for initialization
    void Start()
    {
        startingTime = Time.time;

        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        const float timeBeforeFade = 0.3f;
        const float fadeDuration = 0.2f;

        var timeSinceSpawned = Time.time - startingTime;

        if (timeSinceSpawned > timeBeforeFade)
        {
            renderer.color = new Color(255, 255, 255, 1f - (timeSinceSpawned - timeBeforeFade)/fadeDuration);

            if (timeSinceSpawned > (timeBeforeFade + fadeDuration))
            {
                Destroy(gameObject);
            }

        }
    }
}
