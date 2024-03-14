using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNucleon : MonoBehaviour
{
    private GameObject protonButton;
    private GameObject neutronButton;
    public GameObject proton;
    public GameObject neutron;

    // Start is called before the first frame update
    void Start()
    {
        protonButton = GameObject.FindGameObjectWithTag("proton");
        neutronButton = GameObject.FindGameObjectWithTag("neutron");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addProton()
    {
        Instantiate(proton);
    }
    public void addNeutron()
    {

        Instantiate(neutron);
    }
}
