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
        if (currHealth > 0) //Управление объектом будет доступно, если здоровье выше нуля
        {
            float moveX = Input.GetAxis("Horizontal"); //Получение направления движения
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime); //Изменение позиции
            if (Input.GetKeyDown(KeyCode.UpArrow)) //Действия при нажатии стрелочки вверх
            {
                JumpAudio.Play();
                rb.AddForce(Vector2.up * jumpForce); //Добавление силы прыжка
            }
        }
        else
        {
            Destroy(gameObject); //Если здоровье ниже нуля, то объект будет удален
                                 //Обратите внимание, что в качестве аргумента указан gameObject, а не this
                                 //Если указать this, то для текущего объекта будет отключен этот скрипт
        }

    }       
        public float maxHealth = 100; //Здоровье игрока
        public float currHealth = 100;
        public Rigidbody2D rb; //С помощью Rigidbody 2D будет осуществляться управление объектом
        public float jumpForce = 7000f; //Сила прыжка
        public float speed = 5f; //Скорость движения

}
