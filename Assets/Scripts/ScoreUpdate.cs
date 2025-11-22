using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUI;
    [SerializeField] GameObject targetObject;

    private RaycastHit hit;
    private int score = 0;


    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {

            if (hit.collider.gameObject == targetObject)
            {
                Debug.Log(hit.transform.gameObject.name);
                score++;
                ScoreUI.text = score.ToString("D2");
            }
        }
    }
}
