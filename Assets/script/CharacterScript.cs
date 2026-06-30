using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] float speed;

    [SerializeField] float jumpForce;

    [SerializeField] GameObject menu;

    bool isGrounded;

    bool isGameOver;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (!isGameOver)
        {
            // Se il giocatore preme A e il personaggio non si trova gia sulla corsia di sinistra, allora
            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
            {
                transform.Translate(-9, 0, 0);
            }

        // Se il giocatore preme D e il personaggio non si trova gia sulla corsia di destra, allora
            if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
            {
                // Spostamento del personaggio di 9 unita a destra
                transform.Translate(9, 0, 0);
            }
        }
    }

    void FixedUpdate()
    {
        if(!isGameOver)
        {
            transform.Translate(0,0, speed * Time.deltaTime);

            // Salto: solo se il personaggio e a terra
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpForce, speed);
                isGrounded = false;
            }
        }
    }


    bool IsFloor(Collider other)
    {
        Transform current = other.transform;

        while (current != null)
        {
            if (current.CompareTag("Floor"))
            {
                return true;
            }

            current = current.parent;
        }

        return false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (IsFloor(collision.collider))
        {
            isGrounded = true;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (IsFloor(collision.collider))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            menu.SetActive(true);
        }
    }


    void OnCollisionExit(Collision collision)
    {
        if (IsFloor(collision.collider))
        {
            isGrounded = false;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
