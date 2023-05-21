using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
	void OnTriggerEnter(Collider col){
		Scoree.coinA += 1;
		Destroy (gameObject);
	}
}
