using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    [Header("Keyboard Controls (for testing)")]
    public KeyCode playPauseKey = KeyCode.Space;
    public KeyCode stopKey = KeyCode.S;

    void Start()
    {
        if (videoPlayer != null)
        {
            // Make sure it doesn't auto-play
            videoPlayer.playOnAwake = false;
            videoPlayer.Stop();
        }
    }

    void Update()
    {
        if (videoPlayer == null) return;

        // Play / Pause toggle with Space
        if (Input.GetKeyDown(playPauseKey))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                // If you want it to always restart from beginning when pressing Space:
                // videoPlayer.time = 0;
                videoPlayer.Play();
            }
        }

        // Stop with S
        if (Input.GetKeyDown(stopKey))
        {
            StopVideo();
        }
    }

    public void PlayVideo()
    {
        if (videoPlayer == null) return;

        // Uncomment if you want it to always restart from beginning:
        // videoPlayer.time = 0;

        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        if (videoPlayer == null) return;

        videoPlayer.Pause();
    }

    public void StopVideo()
    {
        if (videoPlayer == null) return;

        videoPlayer.Stop();
        // Optional: ensure it resets to start
        videoPlayer.time = 0;
    }
}

/*
STEPS:
Go to unity hub
Create a new project, and choose built in 3d pipeline

Importing stuff - Windows -> packet management -> packet manager -> unity registry
	Xr interaction toolkit, then go to sample and import starter asset
	Xr plugin management
	Open Xr plugin

Go to file -> build profiles -> player settings on the right side, then go to player and - 
	Active input handling make it both
	Go to Xr interaction tool, enable xr interaction simulator
	
BACK TO UNITY–
Can delete main camera
In project window, take the ‘XR Rig’ controller and drop it into sample scene
In hierarchy, right click, 3rd objects, take a plane (scale up 5,5,5)
To give colour to the base, in project window - asset -> create -> material -> choose a colour -> you’ll get a material in asset window -> drag that and drop to the plane.

Now we need another plane, and make sure it comes infront of the camera
Rotate this new plane (-90), rename it as screen, adjust and rescale

Now to import video, asset right click, import package, custom package
Drag the video and leave it on screen.

Now, attaching buttons - 
Right click in sample scene, go to UI, select buttons and import essentials ( tmp essentials and extras ) which popup
Change the settings in canvas of sample space - from screen space overlay to world space.
Get the button into the world just below the scree, and make 3 copies of the button.
Rearrange and rename the buttons (in text tmp)

In project, Asset, create, scripting, Empty c# script, rename it as VideoController
Open editor (click on open button on top) -> copy the program and paste it

Now we should attach the script to the screen - 
Go to the screen, on the right window scroll down, click add component, and select VideoController.
Drag video player and drop it in video player field in the video controller section

Now we should configure the buttons 
Go to canvas in samplespce
Go to first button, in the right window, go to ‘on-click’, click on ‘+’, 
drag and drop the screen from samplespc to ‘None(object)’ option in on-click , and under no-function, select video controller and choose pause option
Do the above steps for the left over 2 buttons. (stop and play)

Click on run option to run the project and click on the buttons to check if it is working, if ir doesnt work, just give up.
*/