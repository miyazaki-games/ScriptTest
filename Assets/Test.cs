using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        // 配列宣言
        int[] array = { 111, 222, 333, 444, 555, 666 };

        // 順番表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("順番表示: " + array[i]);
        }

        // 逆順表示
        for (int j = 5; j > -1; j--)
        {
            Debug.Log("逆順表示: " + array[j]);
        }

        Boss boss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        boss.Magic();
    }

    void Update()
    {
        
    }
}
