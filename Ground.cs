using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{

    public float movespeed = 3;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * movespeed);
        if (transform.position.x <= -20)
            Destroy(gameObject);
    }
}