using UnityEngine;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Space space;
    public Laser laserPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        space = FindObjectOfType<Space>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * speed;
        }
        else if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void LateUpdate()
    {
        float topBound = 8f;
        float bottomBound = 2f;
        float leftBound = -4f;
        float rightBound = 4f;

        float clampedX = Mathf.Clamp(transform.localPosition.x, leftBound, rightBound);
        float clampedY = Mathf.Clamp(transform.localPosition.y, bottomBound, topBound);
        Vector3 curPos = transform.localPosition;
        transform.localPosition = new Vector3(clampedX, clampedY, curPos.z);
    }

    private void Shoot()
    {
        Instantiate(this.laserPrefab, this.transform.position, Quaternion.Euler(new Vector3(270, 0, 0)));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trash")
        {
            space.Status(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
