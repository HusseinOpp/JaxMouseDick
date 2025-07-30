using UnityEngine;

public class SOundTrigger : MonoBehaviour
{
    public AudioClip SOund;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(SOund, transform.position);
            Debug.Log("Enter");
            Destroy(gameObject);
        }
    }
}
