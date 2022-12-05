using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerCountDown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timer=180f;
    // Start is called before the first frame update
    void Start()
    {
        timerText= GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        if(CapsuleColliderKJMove.loadflag){
            timer-=Time.deltaTime;
            float minutes=Mathf.FloorToInt(timer/60);
            float seconds=Mathf.FloorToInt(timer%60);
            timerText.text=string.Format("{0:00}:{1:00}",minutes,seconds)+"    "+"Tech Collected "+Score.totalscore+"/7 ";
            if(timer<0){//lose
            SceneManager.LoadScene(3);
            }
            if(Score.totalscore==7){//win
                SceneManager.LoadScene(2);
            }
        }
    }
}
