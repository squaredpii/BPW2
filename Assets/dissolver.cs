using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissolver : MonoBehaviour
{
    public float dissolveDuration = 2;
    public float dissolveStrength;
    public GameObject trigger;


    public void StartDissolver()
    {
        StartCoroutine(dissolveer());
    }
    public IEnumerator dissolveer()
    {
        float elapsedTime = 0;

        Material dissolveMaterial = GetComponent<Renderer>().material;

        while (elapsedTime < dissolveDuration)
        {
            elapsedTime += Time.deltaTime;

            dissolveStrength = Mathf.Lerp(0, 1, elapsedTime / dissolveDuration);
            dissolveMaterial.SetFloat("_dissolvestrength", dissolveStrength);

            yield return null;
        }
    }

    private void Update()
    {
        if (trigger.GetComponent<BoxCollider>().enabled == false)
        {
            StartDissolver();
        }
    }
}
