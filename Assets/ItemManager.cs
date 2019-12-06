using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ItemManager : MonoBehaviour
{
    public int goalBananas = 3;
    public int bananas = 0;
    public int goalLemons = 2;
    public int lemons = 0;
    public int goalBatata = 1;
    public int batata = 0;

    public GameObject target;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;
    public GameObject target7;



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
            target.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(true);
            target1.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(false);
            target6.SetActive(false);

        }
        if (bananas == goalBananas && batata == goalBatata)
        {
            Debug.Log("Win");
            target.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(false);
            target1.SetActive(false);
            target4.SetActive(false);
            target6.SetActive(false);
            target5.SetActive(true);

        }
        if (lemons == goalLemons && batata == goalBatata)
        {
            Debug.Log("Win");
            target.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(false);
            target1.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(false);
            target6.SetActive(true);


        }
        if (lemons == goalLemons && batata == goalBatata && bananas == goalBananas)
        {
            Debug.Log("Win");
            target.SetActive(false);
            target2.SetActive(false);
            target3.SetActive(false);
            target1.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(false);
            target6.SetActive(false);
            target7.SetActive(true);

            SceneManager.LoadScene(0);



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
        if(snapped.name.StartsWith("Larange"))
        {
            bananas++;
            if(bananas == goalBananas)
            {
                Debug.Log("Winner");
                target.SetActive(true);
                target1.SetActive(false);
                AchieveGoal();
            }
        }
        if (snapped.name.StartsWith("Maca"))
        {
            lemons++;
            if (lemons == goalLemons)
            {
                Debug.Log("Winner");
                target2.SetActive(true);
                target1.SetActive(false);
                AchieveGoal();
            }
        }
        if (snapped.name.StartsWith("Melancia"))
        {
            batata++;
            if (batata == goalBatata)
            {
                Debug.Log("Winner");
                target4.SetActive(true);
                target1.SetActive(false);
                AchieveGoal();
            }
        }

    }
}
