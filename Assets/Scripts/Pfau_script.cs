using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pfau_script : MonoBehaviour
{
    public static Rigidbody2D pfaur2d;
    public static Animator pfauanim;
    public static Transform pfautrans;
    public static SpriteRenderer pfausprite;
    public static Sprite[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        pfaur2d = GetComponent<Rigidbody2D>();
        pfauanim = GetComponent<Animator>();
        pfautrans = GetComponent<Transform>();
        pfausprite = GetComponent<SpriteRenderer>();
	sprite = Resources.LoadAll<Sprite>("../Textures/pfau_vorn");
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetKey("right"))
	{
		pfaur2d.velocity = new Vector2(2,0);
		pfauanim.enabled = true;
	}
	else if (Input.GetKey("left"))
	{
		pfaur2d.velocity = new Vector2(-2,0);
		pfauanim.enabled = true;
	}
	else
	{
		pfaur2d.velocity = new Vector2(0,0);
		pfauanim.enabled = false;
		pfausprite.sprite = sprite[0];
	}
    }
}
