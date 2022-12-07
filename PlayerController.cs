using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    /// Variables del movimiento del personaje
    public float jumpForce = 6f;

    Rigidbody2D rigidBody;

    public LayerMask groundMask;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    /// Start is called before the first frame update
    void Start()
    {
        
    }

    /// Update is called once per frame
    void Update()
    {   //Indica con qué teclas salta el personaje
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    ///Indica de qué manera salta el personaje
    void Jump ()
    {
        if (IsTouchingTheGround())
        {
            rigidBody.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
        }
    }

    ///Nos idica si está o no tocando el suelo
    bool IsTouchingTheGround()
    {
        if(Physics2D.Raycast(this.transform.position,
                            Vector2.down,
                            2.0f,
                            groundMask))
         ///Programar lógica de contacto con el suelo
        {
            //TODO: programar lógica de contacto con el suelo
            return true;
        }
        ///Programar lógica de no contacto con el suelo
        else
            {
                //TODO: programar lógica de no contacto con el suelo
                return false;
            }
        
    }
}
