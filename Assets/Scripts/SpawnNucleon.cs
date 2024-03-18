using JetBrains.Annotations;
using System;
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
            if (checkProton())
            {
                Transform protonTransform = spawnPoints[count].transform;
                var copy = Instantiate(proton, protonTransform);
                count++;
                protonStack.Push(copy);
                protonCount++;
            }
            else
            {
                Debug.Log("Invalid Combination");
            }
        }
        
    }
    public void addNeutron()
    {
        if (checkNeutron())
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
        else
        {
            Debug.Log("Invalid");
        }
    }

    public void destroyProton()
    {
        if (protonDestroyCheck())
        {
            if (protonCount > 0)
            {
                Destroy(protonStack.Pop());
                count--;
                protonCount--;
            }
        }
    }
    public void destroyNeutron()
    {
        if (neutronDestroyCheck())
        {
            if (neutronCount > 0)
            {
                Destroy(neutronStack.Pop());
                count--;
                neutronCount--;
            }
        }
    }

    public Boolean checkProton()
    {
        if (protonCount == 0 && neutronCount <= 1)
        {
            return true;
        }
        else if (protonCount == 1 && neutronCount >= 1 && neutronCount <= 6)
        {
            return true;
        }
        else if (protonCount == 2 && neutronCount >= 1 && neutronCount <= 8)
        {
            return true;
        }
        else if (protonCount == 3 && neutronCount <= 9 && neutronCount >= 1)
        {
            return true;
        }
        else if (protonCount >= 4 && protonCount <= 6 && neutronCount >= 2)
        {
            return true;
        }
        else if (protonCount >= 6 && protonCount <= 8 && neutronCount >= 3)
        {
            return true;
        }
        else if (protonCount == 9 && neutronCount >= 4)
        {
            return true;
        }
        else if (protonCount >= 9 && neutronCount >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Boolean checkNeutron()
    {
        if (protonCount <= 0 && neutronCount == 0)
        {
            return true;
        }
        else if (protonCount == 1 && neutronCount >= 0 && neutronCount < 6)
        {
            return true;
        }
        else if (protonCount == 2 && neutronCount >= 1 && neutronCount < 8)
        {
            return true;
        }
        else if (protonCount == 3 && neutronCount < 9 && neutronCount >= 1)
        {
            return true;
        }
        else if (protonCount >= 4 && protonCount <= 6 && neutronCount >= 2)
        {
            return true;
        }
        else if (protonCount >= 6 && protonCount <= 8 && neutronCount >= 3)
        {
            return true;
        }
        else if (protonCount == 9 && neutronCount >= 4)
        {
            return true;
        }
        else if (protonCount >= 9 && neutronCount >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public Boolean protonDestroyCheck()
    {
        //if (protonCount == 0 && neutronCount <= 1)
        //{
        //    return false;
        //}
        //else if (protonCount == 1 && neutronCount == 1)
        //{
        //    return false;
        //}
        if (protonCount == 2 && neutronCount == 1 )
        {
            return true;
        }
        else if (protonCount == 3 && neutronCount == 1)
        {
            return true;
        }
        else if (protonCount >= 4 && protonCount == 2)
        {
            return true;
        }
        else if (protonCount >= 6 && protonCount == 3)
        {
            return true;
        }
        else if (protonCount == 9 && neutronCount == 4)
        {
            return true;
        }
        else if (protonCount >= 9 && neutronCount == 5)
        {
            return true;
        }
        else
        {
            return true;
        }


        
    }

    public Boolean neutronDestroyCheck()
    {
        if(neutronCount == 1 && protonCount <=3 )
        {
            return false;
        }
        else if(neutronCount == 2 && protonCount <= 6  && protonCount>3)
        {
            return false;
        }
        else if (neutronCount == 3 && protonCount <= 8 && protonCount > 6)
        {
            return false;
        }
        else if (neutronCount ==4  && protonCount <= 10 && protonCount > 8)
        {
            return false;
        }
        else if (neutronCount == 5 && protonCount <= 6 && protonCount > 3)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
