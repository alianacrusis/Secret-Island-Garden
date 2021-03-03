using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Teleporter : MonoBehaviour
{
    //public Color inactive;
    //public Color gazedAt;
    public GameObject player;

    private MeshRenderer myRenderer;
    //private bool colorChanging = false;
    private bool canMove = false;

    private Transform teleportPos;
    public GameObject spawnPoint;
    private float myTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //myRenderer = GetComponent<MeshRenderer>();
        //myRenderer.material.color = inactive;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            //myRenderer.material.color = Color.Lerp (myRenderer.material.color, gazedAt, Time.deltaTime * 2);
            myTimer += Time.deltaTime;

            if (myTimer >= 2f)
            {
                Vector3 pos = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
                player.transform.position = pos;
            }
        }
    }

    public void GazeAt (bool gazing)
    {
        if (gazing)
        { 
            canMove = true;
            GetComponent<ParticleSystem>().Play();
        }

        else
        {
            myTimer = 0f;
            canMove = false;
            //myRenderer.material.color = inactive;
            GetComponent<ParticleSystem>().Stop();
        }
    }

    /*public void MoveToPos()
    {
        if (canMove)
        {
            Vector3 pos = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
            player.transform.position = pos;
        }
    }*/
}
