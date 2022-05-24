using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodCollector : MonoBehaviour
{
    [HideInInspector] public int LumberCount { get; private set; }
    public TextMeshProUGUI lumberAmountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Constants.WOOD))
        {
            LumberCount++;
            lumberAmountText.text = LumberCount.ToString();
            Destroy(other.gameObject);
        }
    }
}
