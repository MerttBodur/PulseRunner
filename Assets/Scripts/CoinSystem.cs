using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public GameObject effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        // PlayerController'ý çarpýþan objeden veya parent'tan bul
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player == null) player = collision.GetComponentInParent<PlayerController>();

        if (player == null)
        {
            Debug.LogError("CoinSystem: PlayerController bulunamadý. Hit = " + collision.name);
            return;
        }

        player.coin++;
        Destroy(gameObject);

        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
