using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerController player;
    public DoorController door;

    public TMP_Text coinCount;
    public TMP_Text deathCount;
    public TMP_Text doorStatus;

    void Update()
    {
        if (player != null)
        {
            coinCount.text = "Coin: " + player.coin.ToString();
            deathCount.text = "Deaths: " + PlayerController.deathCount.ToString();
        }

        if (door != null)
        {
            if (door.isDoorOpen)
                doorStatus.text = "Door: OPEN";
            else
                doorStatus.text = "Door: LOCKED";
        }
    }
}