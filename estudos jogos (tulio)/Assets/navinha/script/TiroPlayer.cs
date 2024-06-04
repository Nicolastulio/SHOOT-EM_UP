using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TiroPlayer : MonoBehaviour
{

    

    

    [Header("componentes")]
    public Rigidbody2D corpoTiro;
    public BoxCollider2D colisorTiro;
    public Animator animatorAlan;

    [Header("tiro/botão")]

    [Header("Movimentação")]
    public float velovidade;

    [Header("Colisao")]
    public Animator explosao;
    //  public bool isCollision;

    private void Awake()
    {
    //    oAnimator = GetComponent<Animator>();
    }



    // Start is called before the first frame update
    void Start()
    {
   //     explosao.SetActive(false);
   //     colisorTiro =  GetComponent<BoxCollider2D>();
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
            GameManager.Instance.AlterarScore(10);

            animatorAlan.SetInteger("explosao", 1);


            Destroy(collision.gameObject);
            Destroy(gameObject);
         
            //   StartCoroutine(Explodir());

        }
    }

  //  IEnumerator Explodir()
 //   {
  //      Instantiate(explosao,       , Quaternion.identity);
  //      {
   //         throw new NotImplementedException();

    //    }

        
    }

   

