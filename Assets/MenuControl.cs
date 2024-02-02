using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] List<Transform> _itensMenu;
    IEnumerator TimeItens()
    {     
       for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].DOScale(1.5f, .25f);
            yield return new WaitForSeconds(.25f);
            _itensMenu[i].DOScale(1f, .25f);
        }
    }
    public void MenuOff()
    {
        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].transform.localScale = Vector3.zero;
        }
    }

    public void ChamarMenu()
    {
        _itensMenu[0].GetComponent<Button>().Select();
        StartCoroutine(TimeItens());
    }
}
