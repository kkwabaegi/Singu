using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;          //플레이어 속도
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))          //위쪽 화살표가 누르고 있을 때
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);    //오브젝트의 위치를 현재 위치에서 위 방향으로 Speed 만큼 움직인다
        }
        if (Input.GetKey(KeyCode.DownArrow))          
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);  
        }
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }*/

        if(transform.position.y >3)
        {
            transform.position = new Vector2(transform.position.x, 3);
        }
        if (transform.position.y <  -3)
        {
            transform.position = new Vector2(transform.position.x, -3);
        }
    }
}
