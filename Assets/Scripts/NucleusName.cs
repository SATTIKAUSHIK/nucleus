
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class NucleusName : MonoBehaviour
{
    public SpawnNucleon spawnNucleon;
    public TextMeshProUGUI text;
    public TextMeshProUGUI alert;
    public TextMeshProUGUI protonText;
    public TextMeshProUGUI neutronText;
    private int proton;
    private int neutron;
    private bool exists;
    private List<string> hydrogen = new List<string>() { "Hydrogen-1", "Hydrogen-2", "Hydrogen-3", "Hydrogen-4", "Hydrogen-5", "Hydrogen-6", "Hydrogen-7" };
    private List<string> helium = new List<string>() { "Helium-3", "Helium-4", "Helium-5", "Helium-6", "Helium-7", "Helium-8", "Helium-9", "Helium-10" };
    private List<string> lithium = new List<string>() { "Lithium-4", "Lithium-5", "Lithium-6", "Lithium-7", "Lithium-8", "Lithium-9", "Lithium-10", "Lithium-11", "Lithium-12" };
    private List<string> beryllium = new List<string>() { "Beryllium-6", "Beryllium-7", "Beryllium-8", "Beryllium-9", "Beryllium-10", "Beryllium-11", "Beryllium-12", "Beryllium-13", "Beryllium-14", "Beryllium-15", "Beryllium-16" };
    private List<string> boron = new List<string>() { "Boron-7", "Boron-8", "Boron-9", "Boron-10", "Boron-11", "Boron-12", "Boron-12", "Boron-13", "Boron-14", "Boron-15", "Boron-16", "Boron-17" };
    private List<string> carbon = new List<string>() { "Carbon-8", "Carbon-9", "Carbon-10", "Carbon-11", "Carbon-12", "Carbon-12", "Carbon-13", "Carbon-14", "Carbon-15", "Carbon-16", "Carbon-17", "Carbon-18" };
    private List<string> nitrogen = new List<string>() { "Nitrogen-9", "Nitrogen-10", "Nitrogen-11", "Nitrogen-12", "Nitrogen-13", "Nitrogen-14", "Nitrogen-15", "Nitrogen-16", "Nitrogen-17", "Nitrogen-18", "Nitrogen-19" };
    private List<string> oxygen = new List<string>() { "Oxygen-11", "Oxygen-12", "Oxygen-13", "Oxygen-14", "Oxygen-15", "Oxygen-16", "Oxygen-17", "Oxygen-18", "Oxygen-19", "Oxygen-20", };
    private List<string> flourine = new List<string>() { "Flourine-13", "Flourine-14", "Flourine-15", "Flourine-16", "Flourine-17", "Flourine-18", "Flourine-19", "Flourine-20", "Flourine-21" };
    private List<string> neon = new List<string>() { "Neon-15", "Neon-16", "Neon-17", "Neon-18", "Neon-19", "Neon-20", "Neon-21", "Neon-22" };
    private Dictionary<int, List<string>> nucleus = new Dictionary<int, List<string>>();

    void Start()
    {
        nucleus = new Dictionary<int, List<string>>()
        {
            {1, hydrogen},
            {2, helium},
            {3, lithium},
            {4, beryllium},
            {5, boron},
            {6, carbon},
            {7, nitrogen},
            {8, oxygen},
            {9, flourine},
            {10, neon}
        };
    }

    void Update()
    {
        exists = spawnNucleon.exists;
        proton = spawnNucleon.protonCount;
        neutron = spawnNucleon.neutronCount;
        printText();
        protonText.text = "Proton: " + proton.ToString();
        neutronText.text = "Neutron: " + neutron.ToString();
    }
    public void falseCondition()
    {
        StartCoroutine(ShowMessageCoroutine());
    }
    void printText()
    {
        //if (proton == 0 || neutron == 0)
        //{
        //    if (proton == 2 || neutron == 2)
        //    {
        //        alert.text = "Invalid combination";
        //        StartCoroutine(ShowMessageCoroutine());
        //    }
        //}
       
         if(exists == true)
        {
            alert.text = "";
            if (proton == 0 && neutron == 0)
            {
                text.text = "";
            }
            else if (proton == 1)
            {
                text.text = nucleus[proton][neutron];
            }
            else if (proton > 0 && proton < 4)
            {
                text.text = nucleus[proton][neutron - 1];
            }
            else if (proton > 3 && proton < 7)
            {
                text.text = nucleus[proton][neutron - 2];
            }
            else if (proton > 6 && proton < 9)
            {
                text.text = nucleus[proton][neutron - 3];
            }
            else if (proton == 9)
            {
                text.text = nucleus[proton][neutron - 4];
            }
            else if (proton == 10)
            {
                text.text = nucleus[proton][neutron - 5];
            }
        }
    }
    IEnumerator ShowMessageCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        if (exists == false)
        {
            alert.text = "Invalid combination";   

        }
        yield return new WaitForSeconds(1);

        alert.text = "";
    }
}  
