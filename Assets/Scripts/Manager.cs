using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   //����Ƽ UI ����� ���� ���̺귯�� ����
using UnityEngine.SceneManagement;      //����Ƽ �� ��ȯ�� ���� ���̺귯�� ����

public class Manager : MonoBehaviour
{
    public Text TimeText;                   //Text UI

    public GameObject BallPrefabs;          //�� ������Ʈ�� Prefabs
    public GameObject GameoverUI;           //���� ����  UI

    private bool ballExists = false;        //���� ���� ���� �����ϴ��� Ȯ���ϴ� bool ����
    private bool Play = false;              //���� ������ ���������� Ȯ���ϴ� bool ����
    private float playTime = 0.0f;          //���� ������ ����� �ð�

    // Start is called before the first frame update
    void Start()
    {
        ballExists = false;
        playTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ballExists == false)             //���� ���� �������� ���� ��
        {
            if (Input.anyKeyDown)           //�ƹ� ��ư�̳� ������
            {
                ballExists = true;          //���� �����Ѵٰ� ����
                Instantiate(BallPrefabs, new Vector2(0, 2), Quaternion.identity);    //���� �������� ����
                Play = true;
            }
        }

        if (Play && ballExists)             //���� �÷��� ���̰�, ���� ������ ��
        {
            playTime += Time.deltaTime;     //�÷��� Ÿ���� �������ְ�

            TimeText.text = "PlayTime : " + playTime.ToString("00.00");   //�÷��� Ÿ�� �ؽ�Ʈ�� ������Ʈ
        }

        if (!Play)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            Destroy(collision.gameObject);
            Play = false;
            GameoverUI.SetActive(true);
        }
    }
}

