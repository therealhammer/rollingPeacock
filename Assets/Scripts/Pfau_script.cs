using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pfau_script : MonoBehaviour
{
    public static Rigidbody2D pfaur2d;
    public static Animator pfauanim;
    public static Transform pfautrans;
    public static SpriteRenderer pfausprite;
    public static BoxCollider2D pfaucoll;
    //public static AudioSource pfauas;
    public GameObject ground;
    public GameObject kaki;
    public Sprite standSprite;
    public Sprite flySprite;
    public Sprite duckSprite;
    public int speed = 2;
    public int yeet = 50;
    // Start is called before the first frame update
    void Start()
    {
        pfaur2d = GetComponent<Rigidbody2D>();
        pfauanim = GetComponent<Animator>();
        pfautrans = GetComponent<Transform>();
        pfausprite = GetComponent<SpriteRenderer>();
        pfaucoll = GetComponent<BoxCollider2D>();
        //pfauas = GetComponent<AudioSource>();
        pfaur2d.freezeRotation = true;
        for(int i = -4; i < 20; i++)
        {
            Instantiate(ground, new Vector3(i * 3, -4, 0), Quaternion.identity);
            Instantiate(kaki, new Vector3(Random.Range(-4f, 20f), -2.5f, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
	List<ContactPoint2D> contacts = new List<ContactPoint2D>();
	int c = pfaucoll.GetContacts(contacts);
	if(c == 0)
	{
		pfausprite.sprite = flySprite;
		pfauanim.enabled = false;
	}
	else
	{
		pfausprite.sprite = standSprite;
	}
	if (Input.GetKey("right"))
	{
		pfaur2d.velocity = new Vector2(speed,pfaur2d.velocity.y);
		if(c!=0)pfauanim.enabled = true;
		pfautrans.localScale = new Vector3(-0.3f, 0.3f, 1);
	}
	else if (Input.GetKey("left"))
	{
		pfaur2d.velocity = new Vector2(-speed,pfaur2d.velocity.y);
		if(c!=0)pfauanim.enabled = true;
		pfautrans.localScale = new Vector3(0.3f, 0.3f, 1);
	}
	else
	{
		pfaur2d.velocity = new Vector2(0,pfaur2d.velocity.y);
		pfauanim.enabled = false;
	}
	if(Input.GetKey("down"))
	{
		pfaur2d.AddForce(new Vector2(0, -yeet/2), ForceMode2D.Impulse);
		pfauanim.enabled = false;
		pfausprite.sprite = duckSprite;
	}
	if (Input.GetKey("up") && c != 0 && (int)pfaur2d.velocity.y == 0)
	{
		pfaur2d.AddForce(new Vector2(0, yeet), ForceMode2D.Impulse);

	}
    }
}
