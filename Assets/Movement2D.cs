using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private void Update()
    {
        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�) -> ���������� 1��ŭ �����δ�.
        // transform.position = transform.position + new Vector3(1, 0, 0) * 1;

        /**
         * transform
         * - ���� �ҼӵǾ� �ִ� ���� ������Ʈ�� Transform ������Ʈ
         */

        // Time.deltaTime�̶� ���� Update() ������� ���� Update() ���۱����� �ð�
        // ��, ������Ʈ ������ �ð�
        transform.position += Vector3.right * 1 * Time.deltaTime;
    }
}
