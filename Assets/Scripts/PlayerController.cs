using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Vector2 inputVec;
	Rigidbody2D rigid;
	public float speed = 3.0f;
	SpriteRenderer sprite;
	// Start is called before the first frame update
	void Start()
	{

	}
	private void Awake()
	{
		sprite = GetComponent<SpriteRenderer>();
		rigid = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		inputVec.x = Input.GetAxisRaw("Horizontal");
		inputVec.y = Input.GetAxisRaw("Vertical");

	}
	private void LateUpdate()
	{
		if (inputVec.x !=0)
		{
			sprite.flipX= inputVec.x<0;
		}
	}
		
	private void FixedUpdate()
	{
		Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
		//3. 위치제어
		rigid.MovePosition(rigid.position + nextVec);


	}
}
