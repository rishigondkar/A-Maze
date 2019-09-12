/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewayforce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(forwardforce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-forwardforce * Time.deltaTime, 0, 0);
        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame


    public Transform camPivot;
    public float heading = 0f;
    public Transform cam;
    private bool finnished = false;

    public Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (finnished)
            return;
            //SceneManager.LoadScene(2);


        heading += Input.GetAxis("Mouse X") * Time.deltaTime *250 ;
        camPivot.rotation = Quaternion.Euler(0, heading, 0);

        var var_x = Input.GetAxis("Horizontal");
        var var_y = Input.GetAxis("Vertical");

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;


        transform.position += (camF * var_y + camR * var_x) * Time.deltaTime * 15;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        timerText.color = Color.red;
        finnished = true;
    }
}

