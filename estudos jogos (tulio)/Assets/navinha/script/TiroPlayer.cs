using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TiroPlayer : MonoBehaviour
{
    [Header("componentes")]
    public Rigidbody2D corpoTiro;
    public BoxCollider2D colisorTiro;

    [Header("tiro/bot�o")]

    [Header("Movimenta��o")]
    public float velovidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        corpoTiro.velocity = new Vector2(0, velovidade);
    }

 //   private void OnCollisionEnter2D(Collision2D collision)
   // {
  //      if (collision.gameObject.CompareTag("Alan")) 
   //     
    //    {
   //         Destroy(collision.gameObject);
   //         Destroy(gameObject);
    //    }
        
  //  }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alan"))

        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


}