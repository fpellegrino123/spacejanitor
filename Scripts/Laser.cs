using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    Space space;
    public AudioSource laserAudio;
    public GameObject explosionPrefab;

    void Start()
    {
        laserAudio.Play();
    }

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        if (this.transform.position.z > 50)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject explosion = Instantiate<GameObject>(explosionPrefab);
        explosion.transform.position = this.transform.position;
        explosion.transform.rotation = this.transform.rotation;
        if (other.tag == "Trash")
        {
            space.Status(other.gameObject);
            GameManager.Instance.AddScores(1);
            Destroy(other.gameObject);
        }
        Destroy(this.gameObject);
    }
}
