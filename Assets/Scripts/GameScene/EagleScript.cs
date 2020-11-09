using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleScript : MonoBehaviour
{
    public float freq;
    public float amp;
    private GameObject thedoor;
    public Animator animator;
    private Animation anim;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    void Start()
    {
        posOffset = transform.position;
        anim = thedoor.GetComponent<Animation>();
    }
    void Update()
    {
        tempPos = posOffset;
        //if(collider2D.isTrigger)
        //{
        //    animator.SetBool("onDeath", false);
        //    //if (!anim.IsPlaying("Eagle_Death"))
        //    //{
        //    //    thedoor.active = false;
        //    //}
        //}

        transform.position = new Vector3(transform.position.x, tempPos.y + Mathf.Sin(Time.fixedTime * Mathf.PI * freq) * amp, transform.position.z);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    SceneManager.LoadScene("YuraScene");
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("onDeath", false);
    }

}