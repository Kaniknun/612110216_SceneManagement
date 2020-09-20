using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SingletonGameManager : MonoBehaviour
{

protected SingletonGameManager(){}

public string ClassName{get;} = "SingletonGameManager";

public int GameScore{get;set;} = 0;




}
