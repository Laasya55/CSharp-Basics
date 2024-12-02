using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountUp : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI[] Texts;
    [SerializeField]
    private float Speed = 1;
    private float TimeDisplay = 0;
    private float[] ArrayOfFloats;
    // Start is called before the first frame update
    void Start()
    {
        ArrayOfFloats = new float[Texts.Length];
        ArrayOfFloats[0] = 12.25f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed > 0) 
        {
            TimeDisplay = TimeDisplay + Time.deltaTime*Speed;
            /*for (int i = 0; i < Texts.Length; i++)
            {
                Texts[i].SetText($"{TimeDisplay.ToString("N2")}");
            }*/
            /*int i = 0;
            while (i < Texts.Length)
            {
                Texts[i].SetText($"{TimeDisplay.ToString("N2")}");
                i++;
            }*/
            /*int i = 0;
            do 
            {
                Texts[i].SetText($"{TimeDisplay.ToString("N2")}");
                i++;
            }
            while ( i < Texts.Length );
            */
            foreach(TextMeshProUGUI text in Texts)
            {
                text.SetText($"{TimeDisplay.ToString("N2")}");
                
            }
            for (int i = 0; i < Texts.Length; i++)
            {
                TextMeshProUGUI text= Texts[i];
                Texts[i].SetText($"{TimeDisplay.ToString("N2")}");
            }

        }
    }
}
