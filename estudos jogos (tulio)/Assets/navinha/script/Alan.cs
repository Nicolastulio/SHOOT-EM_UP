using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Alan : MonoBehaviour
{
    [Header("componentes")]
    public Rigidbody2D corpoAlan;
    public BoxCollider2D colisorAlan;

    [Header("tiro/botão")]

    [Header("Movimentação")]
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
        corpoAlan.velocity = new Vector2(0, velovidade);
    }

    
}
