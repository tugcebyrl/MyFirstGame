using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melons = 0;

    [SerializeField] private Text melonsText;

    [SerializeField] private AudioSource collectionSoundeffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundeffect.Play();
            Destroy(collision.gameObject);
            melons++;
            //Debug.Log("Melons: " + melons);
            melonsText.text = "M E L O N S : " + melons;
        }
    }
}
