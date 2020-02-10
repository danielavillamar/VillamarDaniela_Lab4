using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastController : MonoBehaviour
{
    // VARIABLES RAYCAST
    public float range = 10f;
    public GameObject effect;
    public float force = 4f;
    
    // VARIABLES UI
    private int contador = 0;
    public Text textocontador;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range))
            {
                Debug.Log(hit.collider.name);

                if(hit.collider.gameObject.tag == "Fire")
                {
                    Destroy(hit.collider.gameObject);
                    contador = contador + 1;
                    textocontador.text = "TARGETS DOWN =  " + contador;
                }
                   
                   GameObject _effect = Instantiate(effect, hit.point, Quaternion.identity);
                   Destroy(_effect, 0.8f);
              

            }

        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * range);
    }
}
