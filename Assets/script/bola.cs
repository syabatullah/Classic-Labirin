using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
	public bool isFlat = true;
	private Rigidbody rigid;

	// Start is called before the first frame update
	void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	private void Update()
	{
		Vector3 tilt = Input.acceleration;

		if(isFlat)
			tilt = Quaternion.Euler(100, 0, 0) * tilt;

		rigid.AddForce(tilt);
		Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
	}


}
