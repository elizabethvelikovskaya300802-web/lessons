using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ��������� ������� ���������� PlayerController � �������������� �������
        if (collision.gameObject.TryGetComponent<PlayerController>(out var player))
        {
            // ��������� ������� ���� ����� (500) � Rigidbody ������
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);

            // ������� ��������� � ������� ��� �������
            Debug.Log("����� ��������� ����������!");
        }
    }
}
