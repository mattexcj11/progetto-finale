using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> locations = new List<GameObject>();

    [SerializeField] Transform player;

    float levelLength = 106.3f;

    int count = 4;



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(locations[0], transform.forward, transform.rotation);
        for (int i = 0; i < count; i++)
        {
            CreateLocation();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.z>levelLength - 106.3f)
        {
            CreateLocation();
        }

    }

    void CreateLocation()
    {
    Instantiate(locations[Random.Range(0, locations.Count)], transform.forward* levelLength, transform.rotation);
    levelLength += 106.3f;
    }
}

