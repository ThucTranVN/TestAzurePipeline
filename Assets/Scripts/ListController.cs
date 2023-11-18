using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Linq;

public class ListController : MonoBehaviour
{
    public List<Button> lstDisk;
    public bool isDone = false;
    public GameController gameController;

    public void OnButtonClick(Button button)
    {
        DOTween.CompleteAll();

        int index = lstDisk.IndexOf(button);

        for (int i = index; i < lstDisk.Count; i++)
        {
            CanvasGroup canvasGroup = lstDisk[i].GetComponent<CanvasGroup>();
            canvasGroup.DOFade(0, 0.2f).OnComplete(() =>
                    {
                        canvasGroup.interactable = false;
                    });
        }

        DOVirtual.DelayedCall(0.3f, () =>
          {  
              if (lstDisk.All(btn => btn.GetComponent<CanvasGroup>().interactable == false))
              {
                  isDone = true;
              }

              gameController.CheckEndGame();
          });

        
    }
}
