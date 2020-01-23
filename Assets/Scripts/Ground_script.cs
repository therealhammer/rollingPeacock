using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gras_1;
    public GameObject gras_2;
    public GameObject gras_3;
    public GameObject gras_4;
    public GameObject gras_5;
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            float x = transform.position.x;
            float y = transform.position.y;
            GameObject go = Instantiate(gras_1, new Vector3(x + Random.Range(-1.5f, 1.5f), Random.Range(-5.5f, -2.5f), 0), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Ground").transform;
            go = Instantiate(gras_2, new Vector3(x + Random.Range(-1.5f, 1.5f), Random.Range(-5.5f, -2.5f), 0), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Ground").transform;
            go = Instantiate(gras_3, new Vector3(x + Random.Range(-1.5f, 1.5f), Random.Range(-5.5f, -2.5f), 0), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Ground").transform;
            go = Instantiate(gras_4, new Vector3(x + Random.Range(-1.5f, 1.5f), Random.Range(-5.5f, -2.5f), 0), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Ground").transform;
            go = Instantiate(gras_5, new Vector3(x + Random.Range(-1.5f, 1.5f), Random.Range(-5.5f, -2.5f), 0), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Ground").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
