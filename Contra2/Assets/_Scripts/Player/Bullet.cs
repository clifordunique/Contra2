﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void FixedUpdate()
	{	
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}
}
