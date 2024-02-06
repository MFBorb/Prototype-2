using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogSpawnable = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawnable)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogSpawnable = false;
            StartCoroutine(ResetDogBooleanAfterTime());
        }
    }

    IEnumerator ResetDogBooleanAfterTime() {
        yield return new WaitForSeconds(1.75f);

        dogSpawnable = true;
    }
}
