using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WeakPoint")) { 
        
            Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);
        }
    }
}
