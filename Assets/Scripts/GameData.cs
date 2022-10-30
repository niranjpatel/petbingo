using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static Dictionary<string, int> fruitList = new Dictionary<string, int>();
    public static void InitializeDictionary()
    {
        fruitList.Add("apple", 0);
        fruitList.Add("orange", 0);
        fruitList.Add("peach", 0);
        fruitList.Add("banana", 0);
        fruitList.Add("peanut", 0);
        fruitList.Add("strawberry", 0);
    }
}
