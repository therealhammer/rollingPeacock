using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_script : MonoBehaviour
{
    public static Transform suntrans;
    // Start is called before the first frame update
    void Start()
    {
	suntrans = GetComponent<Transform>();       
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
		suntrans.localScale = new Vector3(1f, 1f, 1);
		yield return new WaitForSeconds(1.1f);
		suntrans.localScale = new Vector3(-1f, 1f, 1);
		yield return new WaitForSeconds(1.1f);
	}
    }
}
