using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
	public float speed = 3.0f;
	public Vector2 inputVec;
	Rigidbody2D rigid;
	SpriteRenderer spriter;
	Animator anim;
	// Start is called before the first frame update
	void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		spriter = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		inputVec.x = Input.GetAxisRaw("Horizontal");
		inputVec.y = Input.GetAxisRaw("Vertical");
	}
	void FixedUpdate()
	{
		Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
		rigid.MovePosition(rigid.position + nextVec);
	}
	private void LateUpdate()
	{
		anim.SetFloat("Speed",inputVec.magnitude);
		if (inputVec.x != 0)
		{
			spriter.flipX = inputVec.x < 0;
		}
	}
}


