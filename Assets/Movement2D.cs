using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

    // �̵� �ӵ�
    private float moveSpeed = 5.0f;
    // �̵� ����
    private Vector3 moveDirection = Vector3.zero;

    // RigidBody2D ��ü ����
    private Rigidbody2D rigid2D;


    // ���� ������Ʈ�� ���ԵǾ� �ִ� RigidBody2D ���� ��������
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // �¿� �̵�
        float x = Input.GetAxisRaw("Horizontal");
        // ��, �Ʒ� �̵�
        float y = Input.GetAxisRaw("Vertical");

        /**
         * Input�� Unity�� Edit - Input Manager ���� ���� -> ����Ű �ҷ��´�.
         * GetAxisRaw("����Ű��") / GetAxis("����Ű��")
         * ����: +1 / ����: -1 / ���: 0
         * 
         * GetAxisRaw�� GetAxis�� ����
         * GetAxisRaw�� Ű�� ������ �ٷ� 1 or -1�� ������
         * GetAxis�� Ű�� ������ ������ 0���� 1 or -1�� ������ �����Ѵ�.
         * (������ ��������)
         * 
         * ���� / ���� ����Ű
         * Horizontal ���� (��, ��) - x��
         *   Positive ����Ű: right, d -> +1
         *   Negative ����Ű: left, a -> -1
         *   Non(�ƹ��͵� �Է�x): 0
         * Vertical ���� - (��, �Ʒ�) - y��
         *   Positive ����Ű: up, w -> +1
         *   Negative ����Ű: down, s -> -1
         *   Non(�ƹ��͵� �Է�x): 0
         *   

         */


        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�) -> ���������� 1��ŭ �����δ�.
        // transform.position = transform.position + new Vector3(1, 0, 0) * 1;

        // �̵� ���� ����
        moveDirection = new Vector3(x, y, 0);

        // ����Ű�� �� ��ġ ����
        // transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Rigidbody2D ������Ʈ�� �ִ� �ӷ� (velocity) ���� ����
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;

        // Time.deltaTime�̶� ���� Update() ������� ���� Update() ���۱����� �ð�
        // ��, ������Ʈ ������ �ð�
        //transform.position += Vector3.right * 1 * Time.deltaTime;

        /**
         * transform
         * - ���� �ҼӵǾ� �ִ� ���� ������Ʈ�� Transform ������Ʈ
        */

    }
}
