using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем наличие компонента PlayerController у столкнувшегося объекта
        if (collision.gameObject.TryGetComponent<PlayerController>(out var player))
        {
            // Применяем большую силу вверх (500) к Rigidbody игрока
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);

            // Выводим сообщение в консоль для отладки
            Debug.Log("Игрок подброшен платформой!");
        }
    }
}
