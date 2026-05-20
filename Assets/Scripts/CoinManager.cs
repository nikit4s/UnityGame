using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coins = 0;

    public TMP_Text coinText;

    void Awake()
    {
        instance = this;
    }

    public void AddCoin()
    {
        coins++;

        coinText.text = coins.ToString();
    }
}