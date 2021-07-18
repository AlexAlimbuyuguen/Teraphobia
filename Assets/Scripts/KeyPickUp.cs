using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    ExitDoor otherscript;
    // Start is called before the first frame update
    void Start()
    {
        otherscript = GetComponent<ExitDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            Debug.Log("Key Picked Up");

            otherscript.enabled = true;
        }
    }

    
}
