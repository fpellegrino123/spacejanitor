using UnityEngine;

public class ExplosionAudio : MonoBehaviour
{
    public AudioSource explosionAudio;

    private void Awake()
    {
        explosionAudio.Play();
    }

    private void Update()
    {
        if (10 - Time.deltaTime == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
