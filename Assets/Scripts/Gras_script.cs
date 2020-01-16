using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gras_script : MonoBehaviour
{public static Transform grastrans;
    // Start is called before the first frame update
    void Start()
    {
	grastrans = GetComponent<Transform>();       
	StartCoroutine("DoSwitch");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DoSwitch()
    {
	while(true) 
	{
		yield return new WaitForSeconds(1f + Random.Range(-0.5f, 1f));
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1);
		yield return new WaitForSeconds(1f + Random.Range(-0.5f, 1f));
		transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1);
	}
    }
}
