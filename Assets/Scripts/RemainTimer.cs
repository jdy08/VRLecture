using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class RemainTimer : MonoBehaviour
{
    [SerializeField] float gameTime = 30.0f;
    Text uiText;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
        currentTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0.0f;
        }

        uiText.text = string.Format("���� �ð� : {0:F} ��", currentTime);
    }

    public bool IsCountingDown()
    {
        return currentTime > 0.0f;
    }
}