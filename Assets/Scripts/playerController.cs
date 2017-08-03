using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


    public Animator animator;
    public float speed;
    public float lifeCycle = 5;
    private float timeToChangeDirection;
    private float walkX = 0;
    private float walkY = 0;

    public float scaleRatio = 5;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        ChangeDirection();
	}
	
	// Update is called once per frame
	void Update () {
        lifeCycle -= Time.deltaTime;
        if (lifeCycle <= 0)
            Destroy(this.gameObject);

        timeToChangeDirection -= Time.deltaTime;

        if (timeToChangeDirection <= 0) {
            ChangeDirection();
        }
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x += walkX;
        moveDirection.y += walkY;

//        Vector3 moveDirection = Vector3.zero;
//
//        if (Input.GetKey(KeyCode.UpArrow))
//            moveDirection.y += 1;
//        if (Input.GetKey(KeyCode.DownArrow))
//            moveDirection.y -= 1;
//        if (Input.GetKey(KeyCode.RightArrow))
//            moveDirection.x += 1;
//        if (Input.GetKey(KeyCode.LeftArrow))
//            moveDirection.x -= 1;
//
        transform.position += moveDirection * speed * Time.deltaTime;

        animator.SetFloat("MoveX",walkX);
        animator.SetFloat("MoveY",walkY);


        transform.localScale = new Vector3(caculateSize(), caculateSize(), 1);
		
	}
    private void ChangeDirection() {

        walkX = Random.Range(-1.0f, 1.0f);
        walkY = Random.Range(-1.0f, 1.0f);

        timeToChangeDirection = 1.5f;
    }

    float caculateSize()
    {
        // return 1~scalRatio

        return (-transform.position.y + 5) / 10 * scaleRatio;
    }

}
