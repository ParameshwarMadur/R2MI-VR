using UnityEngine;

public class DisassemblyManager : MonoBehaviour
{
    public GameObject screw1, screw2, screw3, screw4, screw5, screw6, screw7, screw8;
    public GameObject dummy1, dummy2, dummy3, dummy4, dummy5, dummy6, dummy7, dummy8;

    private GameObject[] screws;
    private GameObject[] dummies;

    private void Start()
    {
        screws = new GameObject[] { screw1, screw2, screw3, screw4, screw5, screw6, screw7, screw8 };
        dummies = new GameObject[] { dummy1, dummy2, dummy3, dummy4, dummy5, dummy6, dummy7, dummy8 };
        for (int i = 0; i < screws.Length; i++)
        {
            screws[i].SetActive(false);
            dummies[i].SetActive(true);
        }
        screws[5].SetActive(true);
        dummies[5].SetActive(false);
    }

    public void ScrewUnscrewed(int actionId)
    {
        if (actionId < screws.Length - 1)
        {
            screws[actionId + 1].SetActive(true);
            dummies[actionId + 1].SetActive(false);
        }
    }
}
