using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Ad2 : MonoBehaviour, IUnityAdsListener
{
    void Start()
    {
        Advertisement.Initialize("5425761");
        Advertisement.AddListener(this);
    }

    public void RAds()
    {
        if (Advertisement.IsReady("Rewarded"))
        {
            Advertisement.Show("Rewarded");
        }
        else
        {
            SceneManager.LoadScene("adsError");
        }
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded" && showResult == ShowResult.Finished)
        {
            SceneManager.LoadScene("Game2");
        }
    }

    public void OnUnityAdsReady(string placementId) { }
    public void OnUnityAdsDidError(string message) { }
    public void OnUnityAdsDidStart(string placementId) { }
}
