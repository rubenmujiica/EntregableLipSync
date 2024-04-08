using System.Collections;
using System.Collections.Generic;
using uLipSync;
using UnityEngine;

public class BakedDataTest : MonoBehaviour
{
    public GameObject lipSyncComp;

    public BakedData data;

    public BakedData data2;

    private uLipSyncBakedDataPlayer bakedPlayer;


    // Start is called before the first frame update
    void Start()
    {
        bakedPlayer = lipSyncComp.GetComponent<uLipSyncBakedDataPlayer>();
        bakedPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(!bakedPlayer.isPlaying)
        {
            bakedPlayer.bakedData = data;
            bakedPlayer.Play();
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Estrella"))
        {
            Debug.Log("Hola");
            bakedPlayer.bakedData = data;
            bakedPlayer.Play();
            
        }

        if (other.gameObject.CompareTag("Enemigo"))
        {
            if(!bakedPlayer.isPlaying){
            bakedPlayer.bakedData = data2;
            bakedPlayer.Play();
            }
        } 
    }
}
