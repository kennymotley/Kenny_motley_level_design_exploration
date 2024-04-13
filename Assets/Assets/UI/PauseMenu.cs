using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public float fadeTime = 1f;
    public float bounceTime = .1f
    private bool canTogglePause = true;

    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        this.transform.localScale = Vector3.zero;
        CanvasGroup = this.GetComponent<CanvasGroup>
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape)) 
    }
}

public void TogglePauseScreen()

    if(canTogglePause == true)

{
    if(this.transform.localScale == Vector3.zero)
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(this.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), fadeTime));
        sequence.Append(this.transform.localScale == Vector3.one, bounceTime));
        sequence.Insert(0f, CanvasGroup.DOFade(1f, fadeTime));

sequence.Play();


        this.transform.localScale = Vector3.one; 
}
else
{
        this.transform.DOScale(Vector3.zero, fadeTime);
        CanvasGroup.DOFade(0f, fadeTime);
    }
}
 
//canTogglePause = false;

//StartCoroutine(WaitForPauseMenu());



private IEnumerator WaitForPauseMenu()
{
    yield return new WaitForSeconds
}