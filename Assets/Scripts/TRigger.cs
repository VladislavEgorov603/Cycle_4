using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRigger : MonoBehaviour
{
    public int Sсore = 0;
    public Text Text_Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Sсore++;
            other.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            other.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
            Text_Score.text = "Score: " + Sсore;
        }
    }
}