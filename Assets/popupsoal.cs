using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupsoal : MonoBehaviour
{
	public GameObject PopUp;
	public bool aktif;

	void Start()
	{

	}


	private void OnTriggerEnter(Collider other)
	{
		OnMouseDown();
	}




	private void OnMouseDown()
	{
		PopUp.SetActive(aktif);
	}


	// Update is called once per frame
	void Update()
	{

	}

}
