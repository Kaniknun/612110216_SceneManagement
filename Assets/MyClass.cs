
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyClass : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(MySingleton.Instance.MyTestString);
        GetComponent<Text>().text=GameApplicationManager.Instance.DIFFICULTY_LEVEL_NAMES[GameApplicationManager.Instance.DifficultyLevel];
    }
}