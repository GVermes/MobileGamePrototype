using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowStar : MonoBehaviour
{
    public GameObject mergeVFX;
    public float durationOfMergeVFX;

    public AudioClip mergedSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "YP")
        {
            StartCoroutine("FadeAway");
            collision.gameObject.SendMessage("FedWithStar");
        }
    }

    IEnumerator FadeAway()
    {
        yield return null;
        AudioSource.PlayClipAtPoint(mergedSFX, Camera.main.transform.position);
        GameObject merged = Instantiate(mergeVFX, transform.position, transform.rotation);
        Destroy(merged, durationOfMergeVFX);
        yield return new WaitForSeconds(0.25f);
        this.gameObject.SetActive(false);
    }
}
