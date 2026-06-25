using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiski : MonoBehaviour
{
    List<string> friends = new List<string>();
    

    void Start()
    {
        friends.Add("ema");
        friends.Add("leo");
        friends.Add("Michael");
        friends.Add("elisa");
        print(friends);

        print(friends[0]); //ema
        print(friends[3]); //elsia
        print(friends[4]); //ArgumentOutOfRangeException: Index was out of range.
    }

// Update is called once per frame
void Update()
    {
        
    }
}
