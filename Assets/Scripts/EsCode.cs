using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsCode : MonoBehaviour
{
    public int Level = 10;              //int(����) Level(���� �̸�)�� �����ϰ� 10 ���� �־���
    public float Hp = 100.0f;           //float(�Ǽ�) Hp(���� �̸�)�� �����ϰ� 100�� ���� �־���
    public bool IsDead = false;         //bool(��/����) IsDead(���� �̸�)�� �����ϰ� ���� ���� �־���
    public string PlayerName = "�̸�";  //string(���ڿ�) PlayerName(���� �̸�)�� �����ϰ� �̸� ���� �־���

    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)    //�ݺ��� for(�ʱ� ����; ���ǹ�; ����� ����)
        {
            Debug.Log(i + "��° �ݺ��Դϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("�̸� : " + PlayerName + "���� : " + Level + "HP : " + Hp);
            Attack(5);

            if(Hp > 0)                  //Hp�� 0���� Ŭ ��
            {
                Debug.Log("���� ü�� : " + Hp);
            }
            else                        //Hp�� 0���� �۰ų� ���� ��
            {
                Debug.Log("�׾����ϴ�.");
                IsDead = true;          //IsDead bool�� ������ ����
            }
        }
    }

    void Attack(float Damage)       //������ �Լ� ����(�Ű� ����)
    {
        Hp = Hp - Damage;
    }
}
