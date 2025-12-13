using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitScript : MonoBehaviour
{
    public List<ProximityButton> catchSpots;
    public Collectible bait;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < catchSpots.Count; i++)
        {
            //catchSpots[i].enabled = false;
            catchSpots[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (bait.isCollected)
        {
            for (int i = 0; i < catchSpots.Count; i++)
            {
                if (catchSpots[i].isFishCaught == false)
                {
                    catchSpots[i].gameObject.SetActive(true);
                }
            }
        }
    }
}
