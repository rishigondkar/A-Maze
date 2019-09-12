
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
