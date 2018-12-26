using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaChave : MonoBehaviour {

    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), 30 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || (other.gameObject.CompareTag("tiro")))
        {
            Destroy(gameObject);
        }
    }
}
