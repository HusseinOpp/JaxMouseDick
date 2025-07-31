using System;
using UnityEngine;

public class SOundTrigger : MonoBehaviour
{
    public AudioClip SOund;
    public  String Tag;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tag))
        {
            AudioSource.PlayClipAtPoint(SOund, transform.position);
            Debug.Log("Enter");
            Destroy(gameObject);
        }
    }
}
