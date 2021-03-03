using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingFlower : MonoBehaviour
{
    public Color inactive;
    public Color gazedAt;
    //public GameObject player;

    private MeshRenderer myRenderer;
    private bool colorChanging = false;
    //private float myTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactive;
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, gazedAt, Time.deltaTime*2);
            //myTimer += Time.deltaTime;

            /*if (myTimer >= 2f)
            {
                Vector3 pos = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
                player.transform.position = pos;
            }*/
        }

        if (!colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, inactive, Time.deltaTime);
        }
    }

    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            colorChanging = true;
            //GetComponent<ParticleSystem>().Play();
        }

        else
        {
            //myTimer = 0f;
            colorChanging = false;
            //GetComponent<ParticleSystem>().Stop();
        }
    }

}
