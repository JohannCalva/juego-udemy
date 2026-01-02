using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShop : MonoBehaviour
{
    [SerializeField]
    private AudioClip _winAudioClip;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                
                if (player != null)
                {
                    if(player.hasCoin == true)
                    {
                        UIManager uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                        if (uIManager != null)
                        {
                            uIManager.UnactiveCoin();
                        }
                        AudioSource.PlayClipAtPoint(_winAudioClip, Camera.main.transform.position, 1f);
                        player.hasCoin = false;
                        player.EnableWeapons();
                    } else
                    {
                        Debug.Log("Get out of here you don't have the coin!");
                    }
                
                    
                    
                    
                }
            }
        }
    }
    //revisar por una colision
    //revisar si es el jugador
    //si el jugador presiona la E
    //Si el jugador tiene la moneda
    // quitar la moneda del jugador
    //actualizar interfaz de inventario
    // reproducir sonido
    //debug SAL DE AQUI
}
