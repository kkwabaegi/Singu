using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   //유니티 UI 사용을 위한 라이브러리 선언
using UnityEngine.SceneManagement;      //유니티 씬 전환을 위한 라이브러리 선언

public class Manager : MonoBehaviour
{
    public Text TimeText;                   //Text UI

    public GameObject BallPrefabs;          //공 오브젝트의 Prefabs
    public GameObject GameoverUI;           //게임 종료  UI

    private bool ballExists = false;        //현재 씬에 공이 존재하는지 확인하는 bool 변수
    private bool Play = false;              //현재 게임이 진행중인지 확인하는 bool 변수
    private float playTime = 0.0f;          //현재 게임이 진행된 시간

    // Start is called before the first frame update
    void Start()
    {
        ballExists = false;
        playTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ballExists == false)             //현재 공이 존재하지 않을 때
        {
            if (Input.anyKeyDown)           //아무 버튼이나 누르면
            {
                ballExists = true;          //공이 존재한다고 변경
                Instantiate(BallPrefabs, new Vector2(0, 2), Quaternion.identity);    //공을 동적으로 생성
                Play = true;
            }
        }

        if (Play && ballExists)             //형재 플레이 중이고, 공이 존재할 때
        {
            playTime += Time.deltaTime;     //플레이 타임을 갱신해주고

            TimeText.text = "PlayTime : " + playTime.ToString("00.00");   //플레이 타임 텍스트에 업데이트
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

