using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject path;
    public GameObject sliding;
   
    


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        sliding.SetActive(false);

        StartCoroutine(finishCut());
    }

    IEnumerator finishCut()
    {
        yield return new WaitForSeconds(15);
        path.SetActive(true);
        cutsceneCam.SetActive(false);
       
        
    }
}
