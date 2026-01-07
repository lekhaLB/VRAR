/*
STEPS:
Make vuforia account and keep login credentials ready
Go to target manager, create a database of device type
Then in that database created, click on add target, and add an image
After that download database in unity editor type


Next go to plan and license, generate basic license
Click on the created license and copy the key

Next go to downloads and download the package ‘Download for unity’

Go to unity hub
Create a new project, and choose built in 3d pipeline

Go to assets, import package, custom package, and locate the vuforia package we downloaded
Now click on Windows, vuforia configuration, and attach the license key on the right window


First delete the main camera in hierarchy
Now in hierarchy, right click to vuforia engine -> AR camera
Then again, right click to vuforia engine -> Image target


Now assets -> import package-> custom package, and import the downloaded database
Now click on image target, and in the right window, ‘Type’ make it ‘from database’,
And for the database box, add this downloaded 5th prgm

Get the image infront of the camera, and rotate it properly
Now add 3d object, sphere and rescale it to small size and place infront of camera
Make this sphere a child of image target 

Now keep the image ready on your phone, camera will open
*/