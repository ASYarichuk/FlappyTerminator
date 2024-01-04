using UnityEngine;

public class Enemy : MonoBehaviour, IInteractable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            Destroy(gameObject);
        }
    }
}
