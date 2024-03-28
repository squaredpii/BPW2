using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cutscene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;


    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(finishCut());
    }

    IEnumerator finishCut()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
