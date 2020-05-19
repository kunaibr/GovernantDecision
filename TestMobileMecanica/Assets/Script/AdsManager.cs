using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{

#if UNITY_IOS
    private string gameID = "3577273";
#elif UNITY_ANDROID
    private string gameID = "3577272";
#endif

    // Start is called before the first frame update
    void Start()
    {
        if (Advertisement.isSupported)
        {
           // Advertisement.AddListener(this);
            Advertisement.Initialize(gameID, false);
        }
    }
    public void btnAnuncioClick()
    {
        if(Advertisement.IsReady("video"))
        Advertisement.Show("video");
    }

    public void btnAnuncioClickBloqueado()
    {
        if (Advertisement.IsReady("rewardedVideo"))
            Advertisement.Show("rewardedVideo");
    }


    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {        // Define conditional logic for each ad completion status:       
        if (showResult == ShowResult.Finished)        {          
            // Reward the user for watching the ad to completion..
            Debug.Log("Viu até o final.");    
        }       
        else if (showResult == ShowResult.Skipped)   
        {     
            // Do not reward the user for skipping the ad.      
            Debug.Log("Viu pulou.");
        }   
        else if (showResult == ShowResult.Failed)    
        {        
            Debug.LogWarning("The ad did not finish due to an error.");    
        }   
    }

    public void btnBanner()
    { 
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show("banner"); 
    }


}

