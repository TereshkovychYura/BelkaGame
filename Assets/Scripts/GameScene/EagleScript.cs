using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleScript : MonoBehaviour
{
    public float freq;
    public float amp;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    void Start()
    {
        posOffset = transform.position;
    }
    void Update()
    {
        tempPos = posOffset;

        transform.position = new Vector3(transform.position.x, tempPos.y + Mathf.Sin(Time.fixedTime * Mathf.PI * freq) * amp, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("YuraScene");
    }
}