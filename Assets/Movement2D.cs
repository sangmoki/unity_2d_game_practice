using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private void Update()
    {
        // 새로운 위치 = 현재 위치 + (방향 * 속도) -> 오른쪽으로 1만큼 움직인다.
        // transform.position = transform.position + new Vector3(1, 0, 0) * 1;

        /**
         * transform
         * - 내가 소속되어 있는 게임 오브젝트의 Transform 컴포넌트
         */

        // Time.deltaTime이란 이전 Update() 종료부터 다음 Update() 시작까지의 시간
        // 즉, 업데이트 사이의 시간
        transform.position += Vector3.right * 1 * Time.deltaTime;
    }
}
