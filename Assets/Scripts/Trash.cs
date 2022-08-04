using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Start()
    {
        this.name = this.name.Replace("(Clone)", "").Trim();
    }

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        if (this.transform.position.z < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
