using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    public GameObject prefab;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * speed;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            float x = transform.localPosition.x;
            float y = transform.localPosition.y;
            float z = transform.localPosition.z;
            Vector3 pos = new Vector3(x, y, z);
            GameObject laser = Instantiate<GameObject>(prefab, pos, Quaternion.identity, transform);
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
}
