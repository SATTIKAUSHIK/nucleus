using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class EnergyLevels : MonoBehaviour
{
    private GameObject protonButton;
    private GameObject neutronButton;
    private GameObject protonDestroyer;
    private GameObject neutronDestroyer;
    public GameObject proton;
    public GameObject neutron;
    //Stack<GameObject> protonStack = new Stack<GameObject>();
    //Stack<GameObject> neutronStack = new Stack<GameObject>();
    public int protonCount = 0, neutronCount = 0;
    //public List<GameObject> spawnPoints = new List<GameObject>();
    //internal bool exists = true;
    public SpawnNucleon spawnNucleon;
    public List<GameObject> spawnProtons = new List<GameObject>();
    public List<GameObject> spawnNeutrons = new List<GameObject>();
    private List<GameObject> protons = new List<GameObject>();
    private List<GameObject> neutrons = new List<GameObject>();
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
        protonCount = spawnNucleon.protonCount;
        neutronCount = spawnNucleon.neutronCount;
    }

    public void addProton()
    {
        //if (protonCount >= 0 && protonCount < 10)
        //{
        //    if (checkProton())
        //    {
        Transform protonTransform = spawnProtons[protonCount].transform;
        var copy = Instantiate(proton, protonTransform);
        //count++;'
        StartCoroutine(ClickColour(protonButton));
        protons.Add(copy);
        //        //protonCount++;
        //        //exists = true;
        //    //}
        //    //else
        //    //{
        //    //    //exists = false;
        //    //    //Thread.Sleep(3000);
        //    //    //exists = true;

        //    //}
        //}

    }
    public void addNeutron()
    {
        //if (checkNeutron())
        //{
        //    if (neutronCount >= 0 && neutronCount < 12)
        //    {
                Transform neutronTransform = spawnNeutrons[neutronCount].transform;
                var copy = Instantiate(neutron, neutronTransform);
        StartCoroutine(ClickColour(neutronButton));
        //count++;
        neutrons.Add(copy);
                //neutronCount++;
                //exists = true;

         //   }
        //}
        //else
        //{
            
        //    //exists = false;
        //    //Thread.Sleep(3000);
        //    //exists = true;
        //}
    }

    public void destroyProton()
    {
        //if (protonDestroyCheck())
        //{
        //    if (protonCount > 0)
        //    {
                Destroy(protons[protonCount -1]);
                protons.RemoveAt(protonCount - 1);
        StartCoroutine(ClickColour(protonDestroyer));
                //count--;
                //protonCount--;
        //        //exists = true;
        //    }
        //}
    }
    public void destroyNeutron()
    {
        //if (neutronDestroyCheck())
        //{
        //    if (neutronCount > 0)
        //    {
                Destroy(neutrons[neutronCount-1]);
                neutrons.RemoveAt(neutronCount-1);
        StartCoroutine(ClickColour(neutronDestroyer));
        //count--;
        //neutronCount--;
        //exists = true;
        //    }
        //}
    }
    IEnumerator ClickColour(GameObject buttun)
    {

        buttun.GetComponent<Image>().color = Color.gray;
        yield return new WaitForSeconds(0.1f);
        buttun.GetComponent<Image>().color = Color.white;

    }
    //public Boolean checkProton()
    //{
    //    if (protonCount == 0 && neutronCount <= 1)
    //    {
    //        return true;
    //    }
    //    else if (neutronCount == 1 && protonCount >=1 && protonCount<3)
    //    {
    //        return true;
    //    }
    //    else if (neutronCount == 2 && protonCount >= 1 && protonCount < 6)
    //    {
    //        return true;
    //    }
    //    else if (neutronCount == 3 && protonCount >= 1 && protonCount < 8)
    //    {
    //        return true;
    //    }
    //    else if (neutronCount == 4 && protonCount >= 1 && protonCount < 9)
    //    {
    //        return true;
    //    }
    //    else if (neutronCount >= 5 && protonCount >= 1 && protonCount < 10)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //public Boolean checkNeutron()
    //{
    //    if (protonCount <= 0 && neutronCount == 0)
    //    {
    //        return true;
    //    }
    //    else if (protonCount == 1 && neutronCount >= 0 && neutronCount < 6)
    //    {
    //        return true;
    //    }
    //    else if (protonCount == 2 && neutronCount >= 1 && neutronCount < 8)
    //    {
    //        return true;
    //    }
    //    else if (protonCount == 3 && neutronCount < 9 && neutronCount >= 1)
    //    {
    //        return true;
    //    }
    //    else if (protonCount >= 4 && protonCount <= 6 && neutronCount >= 2)
    //    {
    //        return true;
    //    }
    //    else if (protonCount >= 6 && protonCount <= 8 && neutronCount >= 3)
    //    {
    //        return true;
    //    }
    //    else if (protonCount == 9 && neutronCount >= 4)
    //    {
    //        return true;
    //    }
    //    else if (protonCount >= 9 && neutronCount >= 5)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}


    //public Boolean protonDestroyCheck()
    //{
    //    //if (protonCount == 0 && neutronCount <= 1)
    //    //{
    //    //    return false;
    //    //}
    //    //else if (protonCount == 1 && neutronCount == 1)
    //    //{
    //    //    return false;
    //    //}
    //    if (protonCount == 2 && neutronCount >6)
    //    {
    //        return false ;
    //    }
    //    else if (protonCount == 3 && neutronCount == 9)
    //    {
    //        return false;
    //    }
    //    else if (protonCount == 4 && protonCount > 9)
    //    {
    //        return false;
    //    }
    //    else
    //    {
    //        return true;
    //    }



    //}

    //public Boolean neutronDestroyCheck()
    //{
    //    if(neutronCount == 1 && protonCount <= 3 && protonCount > 1)
    //    {
    //        return false;
    //    }
    //    else if(neutronCount == 2 && protonCount>3)
    //    {
    //        return false;
    //    }
    //    else if (neutronCount == 3 && protonCount > 6)
    //    {
    //        return false;
    //    }
    //    else if (neutronCount ==4  && protonCount == 9)
    //    {
    //        return false;
    //    }
    //    else if (neutronCount == 5 && protonCount == 10)
    //    {
    //        return false;
    //    }
    //    else
    //    {
    //        return true;
    //    }
    //}
}
