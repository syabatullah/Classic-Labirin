using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lubung : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "bola")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
