using System;
using UnityEngine;
using UnityEngine.Rendering;

public class SOundTrigger : MonoBehaviour
{
    public AudioClip SOund;
    public Transform PlayerPost;
    public bool Isenter;
    public bool IsPlaying = false;
    public bool yes;
    public String Tag;
    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag(Tag))
        {
            // Create a new GameObject at the player's position
            GameObject audioObj = new GameObject("TempAudio");
            audioObj.transform.parent = other.transform; // Parent to player
            audioObj.transform.localPosition = Vector3.zero;

            AudioSource source = audioObj.AddComponent<AudioSource>();
            source.clip = SOund;
            source.Play();
            source.rolloffMode = AudioRolloffMode.Linear;
            source.volume = 0.4f;
            source.spatialBlend = 1;
            source.minDistance = 20;
            source.maxDistance = 30;
            source.loop = true;
            


    
            Destroy(audioObj, SOund.length);
            Debug.Log("Enter");
            Destroy(gameObject);
            
        }
    }
    

}
