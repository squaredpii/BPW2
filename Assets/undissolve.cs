using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undissolve : MonoBehaviour
{
    public float dissolveDuration = 2;
    public float dissolveStrength;


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

            dissolveStrength = Mathf.Lerp(1, 0, elapsedTime / dissolveDuration);
            dissolveMaterial.SetFloat("_dissolvestrength", dissolveStrength);

            yield return null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartDissolver();
        }
    }
}
