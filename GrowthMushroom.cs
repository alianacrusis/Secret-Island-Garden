using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthMushroom : MonoBehaviour
{
    //MeshRenderer reticleRenderer;
    Animator myAnim;

    private bool canGrow = false;
    float myTimer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        //reticleRenderer = GameObject.Find("GvrReticlePointer").GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canGrow)
        {
            myTimer += Time.deltaTime;

            if (myTimer >= 1.25f)
            {
                if (gameObject.tag == "Grow")
                {
                    Grow();
                }

                else if (gameObject.tag == "Mega Grow")
                {
                    MegaGrow();
                }

                else if (gameObject.tag == "Ultra Grow")
                {
                    UltraGrow();
                }

                else if (gameObject.tag == "Max Grow")
                {
                    MaxGrow();
                }
            }
        }
    }

    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            canGrow = true;
            //reticleRenderer.material.SetColor("_Color", Color.green);
            //GetComponent<ParticleSystem>().Play();
        }

        else
        {
            myTimer = 0f;
            canGrow = false;
            //reticleRenderer.material.SetColor("_Color", Color.white);
            //GetComponent<ParticleSystem>().Stop();
        }
    }

    private void Grow()
    {
        myAnim.Play("Grow");
    }

    private void MegaGrow()
    {
        myAnim.Play("MegaGrow");
    }

    private void UltraGrow()
    {
        myAnim.Play("UltraGrow");
    }

    private void MaxGrow()
    {
        myAnim.Play("MaxGrow");
    }
}
