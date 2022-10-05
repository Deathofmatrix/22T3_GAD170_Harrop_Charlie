using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureChecker : MonoBehaviour
{
    [SerializeField] private float currentPorridgeTemperature = 85.0f;

    private float hotLimitTemperature = 70.0f;
    private float coldLimitTemperature = 40.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        currentPorridgeTemperature -= Time.deltaTime * 5f;
    }

    private void TemperatureTest()
    {
        if (currentPorridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot. Temp: " + (int)currentPorridgeTemperature + "C°");
        }

        else if (currentPorridgeTemperature == 55.0f)
        {
            Debug.Log("Perfect!!!!!!!!!!!!!!!! Temp: " + (int)currentPorridgeTemperature + "C°");
        }

        else if (currentPorridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold. Temp: " + (int)currentPorridgeTemperature + "C°");
        }

        else
        {
            Debug.Log("The porridge is just right! Temp: " + (int)currentPorridgeTemperature + "C°");
        }
    }
}
