
using UnityEngine;

public class Light_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
