using UnityEngine;
using UnityEngine.Video;

public class VideoDisplay : MonoBehaviour
{

    [SerializeField] string videoFileName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayVideo();
    }

    public void PlayVideo()
    {
        VideoPlayer vplayer = GetComponent<VideoPlayer>();
        if (vplayer != null)
        {
            string vpath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            //Debug.Log(vpath);
            vplayer.url = vpath;
            vplayer.Play();
        }
    }
}





// Addressable version WORKS WELL WITH android, windows, iOS builds



//using UnityEngine;
//using UnityEngine.Video;
//using UnityEngine.AddressableAssets;
//using UnityEngine.ResourceManagement.AsyncOperations;

//public class VideoDisplay : MonoBehaviour
//{
//    [SerializeField] string videoAddress; // Addressable key

//    void Start()
//    {
//        PlayVideo();
//    }

//    public void PlayVideo()
//    {
//        VideoPlayer vplayer = GetComponent<VideoPlayer>();
//        if (vplayer != null)
//        {
//            Addressables.LoadAssetAsync<VideoClip>(videoAddress).Completed += handle =>
//            {
//                if (handle.Status == AsyncOperationStatus.Succeeded)
//                {
//                    vplayer.clip = handle.Result;
//                    vplayer.Play();
//                }
//                else
//                {
//                    Debug.LogError("Failed to load video: " + videoAddress);
//                }
//            };
//        }
//    }
//}
