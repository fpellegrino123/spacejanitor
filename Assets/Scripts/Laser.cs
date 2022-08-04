using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    Space space;

    void Start()
    {
        space = FindObjectOfType<Space>();
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
        if (other.tag == "Trash")
        {
            space.Status(other.gameObject);
            Destroy(other.gameObject);
        }
        Destroy(this.gameObject);
    }
}
