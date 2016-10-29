using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public Object Sands;
    public Object Ground1;
    public Object Ground2;
    public float wavecountdown = 0;
    public float firstarea = 20;
    public Object floorsprite;
    public float secondarea = 40;

    // Use this for initialization
    void Start()
    {
    floorsprite = Sands;
    }

    // Update is called once per frame
    void Update()
    {
        firstarea -= Time.deltaTime;
        secondarea -= Time.deltaTime;

        if (wavecountdown <= 0)
        {
            Vector3 position = new Vector3(20, -4, 0);
            Instantiate(floorsprite, position, Quaternion.identity);
            wavecountdown = 3;
        }

        else
        {
            wavecountdown -= Time.deltaTime;


            if (firstarea <= 0)
            {
                floorsprite = Ground1;
                firstarea = 40;
            }
            else if (secondarea <= 0)
            {
                floorsprite = Ground2;
                secondarea = 40;
            }
        }
    }

    }

