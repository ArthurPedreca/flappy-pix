using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;
    Rigidbody2D fisica;
    // Start is called before the first frame update
    void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    void Impulsionar()
    {

        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);

        
    }
}
