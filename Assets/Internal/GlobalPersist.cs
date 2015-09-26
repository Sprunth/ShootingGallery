using UnityEngine;
using System.Collections;

public class GlobalPersist : MonoBehaviour
{
    public int Level;

    // Use this for initialization
    void Start()
    {
        Level = 1;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
