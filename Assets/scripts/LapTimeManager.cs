using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;


    private void Update()
    {
        Countcalculation();
    }

    private void Countcalculation()
    {
        MilliCount += Time.deltaTime * 10;
        // �~���b���P�O�O�{���Đ������iint�L���X�g�j����
        int millcount = (int)(MilliCount * 100);

        string addzero = "";
        // 100�̈ʂ�10�̈ʂ��[���Ŗ��߂�
        if (millcount < 10)
        {
            addzero = "00";
        }
        // 100�̈ʂ݂̂�0�Ŗ��߂�
        else if (millcount < 100)
        {
            addzero = "0";
        }
        MilliDisplay = millcount.ToString();

        MilliBox.GetComponent<TextMeshProUGUI>().text = addzero + MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<TextMeshProUGUI>().text = "0" + SecondCount + ".";
        }
        else
        {

            SecondBox.GetComponent<TextMeshProUGUI>().text = "" + SecondCount + ".";
        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TextMeshProUGUI>().text = "0" + MinuteCount + ":";
        }
        else
        {

            MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
        }

    }


}
