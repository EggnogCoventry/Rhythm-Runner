using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public Object Sands;
    public float wavecountdown = 0;

    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (wavecountdown <= 0)
        {
            Vector3 position = new Vector3(20, -4, 0);
            Instantiate(Sands, position, Quaternion.identity);
            wavecountdown = 3;
        }

        else
        {
            wavecountdown -= Time.deltaTime;
        }


    }
}
