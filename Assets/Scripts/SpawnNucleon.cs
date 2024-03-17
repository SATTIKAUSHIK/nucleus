using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNucleon : MonoBehaviour
{
    private GameObject protonButton;
    private GameObject neutronButton;
    private GameObject protonDestroyer;
    private GameObject neutronDestroyer;
    public GameObject proton;
    public GameObject neutron;
    Stack<GameObject> protonStack = new Stack<GameObject>();
    Stack<GameObject> neutronStack = new Stack<GameObject>();
    private int count = 0,protonCount =0,neutronCount =0;
    public List<GameObject> spawnPoints = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] protonButtons = GameObject.FindGameObjectsWithTag("proton");
        GameObject[] neutronButtons = GameObject.FindGameObjectsWithTag("neutron");
        protonButton = protonButtons[0];
        neutronButton = neutronButtons[0];
        protonDestroyer = protonButtons[1];
        neutronDestroyer = neutronButtons[1];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addProton()
    {
        if (protonCount >= 0 && protonCount < 10)
        {

            Transform protonTransform = spawnPoints[count].transform;
            var copy = Instantiate(proton, protonTransform);
            count++;
            protonStack.Push(copy);
            protonCount++;
        }
    }
    public void addNeutron()
    {
        if (neutronCount >= 0 && neutronCount < 12)
        {
            Transform neutronTransform = spawnPoints[count].transform;
            var copy = Instantiate(neutron, neutronTransform);
            count++;
            neutronStack.Push(copy);
            neutronCount++;
        }
    }

    public void destroyProton()
    {
        if (protonCount > 0)
        {
            Destroy(protonStack.Pop());
            count--;
            protonCount--;
        }
    }
    public void destroyNeutron()
    {
        if (neutronCount > 0)
        {
            Destroy(neutronStack.Pop());
            count--;
            neutronCount--;
        }
    }
}
