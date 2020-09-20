using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCharacter : MonoBehaviour
{
    public float speed;
    float zMovement;
    float xMovement;
    float yMovement;

    public float jumpingForce ;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Déplacement et saut
        zMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        xMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        yMovement = Input.GetAxis("Jump") * jumpingForce * Time.deltaTime;

        transform.Translate(xMovement, yMovement, zMovement);        
    }
}
