
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableArea : MonoBehaviour
{

    public GameObject interactionMessage;
    public MercanciaScripts mercancia;

    // Start is called before the first frame update
    void Start()
    {
        interactionMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mercancia)
            {
                mercancia.GetComponent<MercanciaScripts>().onInteraction();
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercancia = other.GetComponent<MercanciaScripts>();

        if (mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        mercancia = null;
    }
}
