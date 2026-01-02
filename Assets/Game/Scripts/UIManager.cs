using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI ammoText;
    [SerializeField]
    private GameObject coinImage;
    public void UpdateAmmo(int currentAmmo)
    {
        ammoText.text = "Ammo: " + currentAmmo.ToString();
    }
    public void CollectedCoin()
    {
        coinImage.SetActive(true);
    }
    public void UnactiveCoin()
    {
        coinImage.SetActive(false);
    }
}
