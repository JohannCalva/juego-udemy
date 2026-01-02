using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private AudioClip _coinPickup;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if(player != null)
                {
                    player.hasCoin = true;
                    UIManager uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                    if(uIManager != null)
                    {
                        uIManager.CollectedCoin();
                    }
                    AudioSource.PlayClipAtPoint(_coinPickup, Camera.main.transform.position, 1f);
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
