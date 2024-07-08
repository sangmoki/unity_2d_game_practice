using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    // 이동 속도
    private float moveSpeed = 5.0f;
    // 이동 방향
    private Vector3 moveDirection = Vector3.zero;

    // RigidBody2D 객체 정의
    private Rigidbody2D rigid2D;


    // 같은 컴포넌트에 포함되어 있는 RigidBody2D 정보 가져오기
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 좌우 이동
        float x = Input.GetAxisRaw("Horizontal");
        // 위, 아래 이동
        float y = Input.GetAxisRaw("Vertical");

        /**
         * Input은 Unity의 Edit - Input Manager 설정 변경 -> 단축키 불러온다.
         * GetAxisRaw("단축키명") / GetAxis("단축키명")
         * 긍정: +1 / 부정: -1 / 대기: 0
         * 
         * GetAxisRaw와 GetAxis의 차이
         * GetAxisRaw는 키를 누르면 바로 1 or -1이 되지만
         * GetAxis는 키를 누르고 있으면 0에서 1 or -1로 서서히 증가한다.
         * (부정도 마찬가지)
         * 
         * 긍정 / 부정 단축키
         * Horizontal 기준 (좌, 우) - x축
         *   Positive 단축키: right, d -> +1
         *   Negative 단축키: left, a -> -1
         *   Non(아무것도 입력x): 0
         * Vertical 기준 - (위, 아래) - y축
         *   Positive 단축키: up, w -> +1
         *   Negative 단축키: down, s -> -1
         *   Non(아무것도 입력x): 0
         *   

         */


        // 새로운 위치 = 현재 위치 + (방향 * 속도) -> 오른쪽으로 1만큼 움직인다.
        // transform.position = transform.position + new Vector3(1, 0, 0) * 1;

        // 이동 방향 설정
        moveDirection = new Vector3(x, y, 0);

        // 방향키로 새 위치 조정
        // transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Rigidbody2D 컴포넌트에 있는 속력 (velocity) 변수 설정
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;

        // Time.deltaTime이란 이전 Update() 종료부터 다음 Update() 시작까지의 시간
        // 즉, 업데이트 사이의 시간
        //transform.position += Vector3.right * 1 * Time.deltaTime;

        /**
         * transform
         * - 내가 소속되어 있는 게임 오브젝트의 Transform 컴포넌트
        */

    }
}
