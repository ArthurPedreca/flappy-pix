using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GeradorObstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject modeloObstaculo;

    [SerializeField]
    private float tempoParaGerar = 0;
    private float cronometro = 0;

    private void Awake() 
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
