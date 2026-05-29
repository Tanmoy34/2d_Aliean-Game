

using UnityEditor.Callbacks;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Rigidbody2D rb = GetComponent<Rigidbody2D>();

       var horizontal = Input.GetAxis("Horizontal");
       //Debug.Log(horizontal);
        
        float Vertical = rb.linearVelocityY;
        if (Input.GetButton("Jump"))
        {
            Vertical = 5;
        }
        


        rb.linearVelocity = new Vector2(horizontal,Vertical); 
    }
}
