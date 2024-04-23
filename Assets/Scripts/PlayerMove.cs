using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    public AudioSource JumpAudio;

    // Update is called once per frame
    void Update()
    {
        if (currHealth > 0) //���������� �������� ����� ��������, ���� �������� ���� ����
        {
            float moveX = Input.GetAxis("Horizontal"); //��������� ����������� ��������
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); //��������� �������
            if (Input.GetKeyDown(KeyCode.UpArrow)) //�������� ��� ������� ��������� �����
            {
                JumpAudio.Play();
                rb.AddForce(Vector2.up * jumpForce); //���������� ���� ������
            }
        }
        else
        {
            Destroy(gameObject); //���� �������� ���� ����, �� ������ ����� ������
                                 //�������� ��������, ��� � �������� ��������� ������ gameObject, � �� this
                                 //���� ������� this, �� ��� �������� ������� ����� �������� ���� ������
        }

    }       
        public float maxHealth = 100; //�������� ������
        public float currHealth = 100;
        public Rigidbody2D rb; //� ������� Rigidbody 2D ����� �������������� ���������� ��������
        public float jumpForce = 7000f; //���� ������
        public float speed = 5f; //�������� ��������

}
