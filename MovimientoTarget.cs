using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTarget : MonoBehaviour
{
    private Vector3 objeto;
    public float speed = 2.0f;
    public float mov = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        objeto = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = objeto;
        a.y += mov * Mathf.Sin(speed * Time.time);
        transform.position = a;
    }
}