using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	[SerializeField] AudioSource collectionSound;
	public GameObject Canvasmenang;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "bola")
        {
			Debug.Log("Game Kalah");
			Canvasmenang.SetActive(true);
			collectionSound.Play();

        }
    }
}
