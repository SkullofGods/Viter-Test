using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel, losePanel;
    public Animator[] animator;
    public void Win()
    {
        foreach (var obj in animator)
        {
            obj.SetBool("Transit",true);
        }

        StartCoroutine(Winning());
    }

    public void Lose()
    {
        losePanel.SetActive(true);
    }

    IEnumerator Winning()
    {
        yield return new WaitForSeconds(.6f);
        winPanel.SetActive(true);
    }
}
