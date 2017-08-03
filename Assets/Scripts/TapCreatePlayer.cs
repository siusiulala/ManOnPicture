using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapCreatePlayer : MonoBehaviour {
    public GameObject[] ink;
    public GameObject player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //get the mouse click position
            Ray hitRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //check for the physics on it and only do it for objects on splatterLayer
            RaycastHit2D hit = Physics2D.GetRayIntersection(hitRay, Mathf.Infinity);
            //if not hitting collider returns
            if (hit.collider == null)
                return;
            //if yes creates the splatter
            if (hit.collider != null)
            {
                print(hit.point);
                Instantiate(ink[Random.Range(0, 6)], hit.point, Quaternion.identity);
                Instantiate(player, hit.point, Quaternion.identity);
            }
        }
	}


}
