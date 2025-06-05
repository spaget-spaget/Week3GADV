using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explodable : MonoBehaviour
{
    public void Explode()
    {
        Debug.Log("Boom!");
        Destroy(gameObject);
    }
}

public class Item : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Explodable>()?.Explode();
        }
    }
}
