using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // ���������, �������� �� ������ ������
        if (collision.gameObject.CompareTag("Player"))
        {
            // ������������� ������ �� ��������� �������
            collision.gameObject.transform.position = new Vector3(5, 1, 5);
        }
    }
}
