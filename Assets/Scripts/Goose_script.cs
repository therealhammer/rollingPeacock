using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goose_script : MonoBehaviour
{
    public GameObject elefant;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(elefant, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
