using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class TimerCountdown : MonoBehaviour
{
  public GameObject textDisplay;
  public int secondsLeft = 30;
  public bool takingAway = false;

  void Start() {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:" + secondsLeft;
  }

void Update() {

        if (secondsLeft == 0)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
  }

  IEnumerator TimerTake(){
      takingAway = true;
      yield return new WaitForSeconds(1);
      secondsLeft -= 1;
      if (secondsLeft < 10)
      {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:0" + secondsLeft;  
      }else
      {
      textDisplay.GetComponent<TextMeshProUGUI>().text = "00:" + secondsLeft;
      }
      takingAway = false;
  }

}
