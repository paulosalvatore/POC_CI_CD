using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    private void Update()
    {
        var x = Random.Range(1, 10);
        var y = Random.Range(1, 10);
        var z = Random.Range(1, 10);
        transform.Rotate(new Vector3(x, y, z) * speed * Time.deltaTime);
    }
}
