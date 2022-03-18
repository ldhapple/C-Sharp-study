using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCtrl : MonoBehaviour {

    private bool run = false;
    private bool walk = false;
    private float h = 0.0f;
    private float v = 0.0f;
    private Transform tr;           // 접근해야 하는 컴포넌트는 반드시 변수에 할당한 후에 사용
    public float moveSpeed = 20.0f; // 이동 속도 변수
    public float rotSpeed = 100.0f;

    void SpeedControl()
    {
        if (run == true)
        {
            moveSpeed = moveSpeed * 1.5f;
        }
        else if (walk == true)
        {
            moveSpeed = moveSpeed * 0.5f;
        }
    }
    
	// Use this for initialization
	void Start () {
        // 스크립트 처음에 Transform 컴포넌트 할당
        tr = GetComponent <Transform > ();

      
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");    // A, D,  Left, Right 키를 눌렀을때
        v = Input.GetAxis("Vertical");      // W, D, Up, Down 키를 눌렀을때

        Debug.Log("h=" + h.ToString());
        Debug.Log("v=" + v.ToString());

        // 전후 좌우 이동 방향 벡터 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            run = true;
            SpeedControl();
            
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            run = false;
        }
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            walk = true;
            SpeedControl();
           
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            walk = false;
        }

        if (run == false && walk == false)
        {
            moveSpeed = 20.0f;
        }




        //Translate(이동 방향 * 속도 * 변위값 * Time.deltaTime, 기준 좌표
        tr.Translate(moveDir.normalized * Time.deltaTime *moveSpeed, Space.Self);

        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

       

    }
}
