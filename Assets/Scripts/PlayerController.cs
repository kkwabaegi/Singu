using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;          //�÷��̾� �ӵ�
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))          //���� ȭ��ǥ�� ������ ���� ��
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);    //������Ʈ�� ��ġ�� ���� ��ġ���� �� �������� Speed ��ŭ �����δ�
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
