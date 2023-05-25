using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{

public float pxfuelSpeed;
 public Renderer pxfuelRend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        pxfuelRend.material.mainTextureOffset += new Vector2(pxfuelSpeed * Time.deltaTime, 0f);
    }
}