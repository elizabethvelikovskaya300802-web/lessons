using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, коснулся ли объект игрока
        if (collision.gameObject.CompareTag("Player"))
        {
            // Телепортируем игрока на стартовую позицию
            collision.gameObject.transform.position = new Vector3(5, 1, 5);
        }
    }
}
