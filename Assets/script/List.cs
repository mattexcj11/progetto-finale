using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // [SerializeField] permette di modificare la lista dall'Inspector
    [SerializeField] private System.Collections.Generic.List<string> friends = new System.Collections.Generic.List<string>();

    void Start()
    {
        // Aggiungere elementi con Add()
        friends.Add("Jack");     // indice [0]
        friends.Add("Ann");      // indice [1]
        friends.Add("Michael");  // indice [2]
        friends.Add("Lisa");     // indice [3]

        // Leggere singoli elementi per indice
        print(friends[0]); // Jack
        print(friends[3]); // Lisa

        // Stampare tutti gli elementi
        foreach (string name in friends)
        {
            print(name);
        }

        for (var i = 0; i < 3; i++)
        {
            print(i);
                
        }
           
    }
}
