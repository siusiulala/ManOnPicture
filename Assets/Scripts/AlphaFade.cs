using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaFade : MonoBehaviour {

    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 2.0f;
    private float startTime;
    public SpriteRenderer sprite;
    public GameObject me;
	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float t = (Time.time - startTime) / duration;
        sprite.color = new Color(.3f,.3f,.3f,Mathf.SmoothStep(maximum,minimum, t));
        if ((Time.time - startTime) > (duration+1))
            Destroy(this.gameObject);
	}
}
