using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerController player;
    public DoorController door;

    public TMP_Text coinCount;
    public TMP_Text deathCount;
    public TMP_Text doorStatus;

    public Image doorStateIcon;  // tik / çarpý

    public Sprite doorOpenSprite; // tik
    public Sprite doorClosedSprite; // X

    void Update()
    {
        if (player != null)
        {
            coinCount.text = "Coin: " + player.coin.ToString();
            deathCount.text = "Deaths: " + PlayerController.deathCount.ToString();
        }

        if (door != null)
        {
            bool open = door.isDoorOpen;

            if (doorStateIcon != null)
            {
                doorStateIcon.sprite = open ? doorOpenSprite : doorClosedSprite;
            }
        }
    }
}