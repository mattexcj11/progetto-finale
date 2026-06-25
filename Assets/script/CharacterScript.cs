using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    [SerializeField] Rigidbody rb;

    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se il giocatore preme e il personaggio non si trova già sulla corsia di sinistra del nostro tracciato, allora
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            // Spostamento del personaggio di 9 unità a sinistra
            transform.Translate(-9, 0, 0);
        }
        // Se il giocatore preme e il personaggio non si trova già sulla corsia di destra del nostro tracciato, allora
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
        {
            // Spostamento del personaggio di 9 unità a destra
            transform.Translate(9, 0, 0);
        }

        
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }
}