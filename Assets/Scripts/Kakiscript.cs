using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakiscript : MonoBehaviour
{
    public static BoxCollider2D kakicoll;
    // Start is called before the first frame update
    void Start()
    {
        kakicoll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pfau")
        {
            Debug.Log("HILFE ICH WERDE VON EINEM PFAU BERUEHRT");
            Destroy(gameObject); 
        }
    }
}
