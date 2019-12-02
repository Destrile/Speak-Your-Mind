using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public int goalBananas = 2;
    public int bananas = 0;
    public int goalLemons = 3;
    public int lemons = 0;
    public GameObject target;
    public GameObject target1;
    public GameObject target2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AchieveGoal()
    {
        if(bananas==goalBananas && lemons == goalLemons)
        {
            Debug.Log("Win");
            target2.SetActive(true);
        }
    }
    public void UnSnappedFruit(GameObject snapped)
    {
        Debug.Log(snapped.name);
        if (snapped.name.StartsWith("Banana"))
        {
            bananas--;
        }
    }
    public void SnappedFruit(GameObject snapped)
    {
        Debug.Log(snapped.name);
        if(snapped.name.StartsWith("Banana"))
        {
            bananas++;
            if(bananas == goalBananas)
            {
                Debug.Log("Winner");
                target.SetActive(true);
                AchieveGoal();
            }
        }
        if (snapped.name.StartsWith("Lemon"))
        {
            lemons++;
            if (lemons == goalLemons)
            {
                Debug.Log("Winner");
                target1.SetActive(true);
                AchieveGoal();
            }
        }
    }
}
