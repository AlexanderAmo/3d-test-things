using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {
	public bool chug;

	private Animator anim;
	private GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator>();

	}
	void OnTriggerEnter(Collider other){
		anim.SetBool ("chug", true);
	}
	void OnTriggerExit(Collider other){
		anim.SetBool ("chug", false);
	}

}
