using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunBrow_script : MonoBehaviour
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
		suntrans.localPosition = new Vector3(0f, 0f, 10);
		yield return new WaitForSeconds(5.2f);
		suntrans.localPosition = new Vector3(0f, 0.2f, 10);
		yield return new WaitForSeconds(.1f);
		suntrans.localPosition = new Vector3(0f, 0f, 10);
		yield return new WaitForSeconds(.1f);
		suntrans.localPosition = new Vector3(0f, 0.2f, 10);
		yield return new WaitForSeconds(.1f);
		suntrans.localPosition = new Vector3(0f, 0f, 10);
		yield return new WaitForSeconds(.1f);
		suntrans.localPosition = new Vector3(0f, 0.2f, 10);
		yield return new WaitForSeconds(.1f);
	}
    }
}
