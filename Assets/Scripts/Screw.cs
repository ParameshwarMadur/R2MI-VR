using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Screw : MonoBehaviour
{
    public string correctToolTag;
    public int actionId;
    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(correctToolTag))
        {
            Unscrew();
        }
    }

    public void Unscrew()
    {
        grabInteractable.enabled = true;
        DisassemblyManager manager = FindObjectOfType<DisassemblyManager>();
        if (manager != null)
        {
            manager.ScrewUnscrewed(actionId);
        }
    }
}
