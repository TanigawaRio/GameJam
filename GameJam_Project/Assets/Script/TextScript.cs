using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    private Queue<char> _charQueue;

    private Queue<char> SeparateString(string str)
    {
        char[] chars = str.ToCharArray();
        Queue<char> charQueue = new Queue<char>();
        foreach (char c in chars) charQueue.Enqueue(c);
        return charQueue;
    }

    

    [SerializeField]
    private Text mainText;
    [SerializeField]
    private string _text = "Hello World";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainText.text = _text;
    }
}
