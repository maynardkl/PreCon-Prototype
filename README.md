# PreCon AR (Prevent Contagious)

<p align="center">
  <img width="460" height="170" src="/[images]/PreCon Logo.png">
</p>

### AR mobile application for training simulation to show people about how we fight this pandemic inside the virtual world. 

Using Augmented Reality (AR), we made PreCon (Prevent Contagious) in order to help the public in experiencing real life situations inside AR. The app helps to educate people on how to prevent this virus from being transmitted. Inside the training simulation, people will interact with the virtual environment and learn how they should act accordingly, because the important thing is to prevent something bad from happening to us rather than try to cure it. Since all the events happen inside the virtual world, this training simulation is safe to use by everyone.

Beside AR training simulation, there are still several features that PreCon have. Here all the feature of this app : 
1. AR Training Simulation. Experience real life training simulation and interact with the object inside the virtual world.
2. Advice from WHO with easy to learn illustration step by step.
3. AR Selfie. Take a selfie photo with a mask and face shield.
4. COVID-19 status all around the world.
5. Intelligent assistant to provide us some answer about everything.

### Involved Technology on this application 
* Unity as our main tools for making the application.
* Using C# Language.
* ARFoundation to provide the Augmented Reality technology.
* Postman public API.
* Wolfram Alpha API as Intelligent Assistant.
* echoAR to provide a flexibility for 3D object and realtime update.
* Speech Recognition

### Final Application (Android minimum OS 7.0 Nougat)
To try PreCon final app (not prototype), can download it from [here](https://precon.rgplays.com/)

### PreCon Video
[<p align="center"><img src="https://img.youtube.com/vi/x3UZioBTqrE/0.jpg"></p>](https://www.youtube.com/watch?v=x3UZioBTqrE)

# PRECON Prototype Projects
All Main Functions and Sample Scenes

### Requirement
* Using Unity 2019.3.6f1
* Minimum OS Android 7.0
* Must have your own ID
  * Register to get Wolfram App ID : [Wolfram](https://account.wolfram.com/auth/create)
  * Register to get echoAR API Key : [echoAR](https://console.echoar.xyz/#/auth/register)

### How to use, edit and try the features of PreCon

* Download [Precon-Technical-Script.unitypackage](https://github.com/maynardkl/PreCon-Prototype/blob/master/PreCon-Technical-Script.unitypackage)
* Create New Unity Project
* Switch Platform to Android

![Switch to Android](/[images]/image1.jpg)
* Install AR Foundation, AR Subsystems, ARCore XR Plugin from Package Manager

![Install ARFoundation](/[images]/image2.jpg)

* Delete Vulkan from Graphic API and set minimum API Level to Android 7.0 Nougat

![Project Setting for Android](/[images]/image3.jpg)
* Import Precon-Technical-Script.unitypackage
* You can start to explore and test the all the samples scene

![Sample Scenes](/[images]/image4.jpg)

* For echoAR scene, you need to add content to your echoAR first and add this Key
For the values
  * about : add any description
  * scale : scaling for the 3D object
  * name : 3D object's name
  * info : The Headline of some News
  * infoLink : url to the News
  
![Sample Scenes](/[images]/image5.JPG)


### Credits Framework
* [echoAR plugin](https://docs.echoar.xyz/unity/installation)
* [Speech Recognition Framework](https://github.com/MatthewHallberg/AndroidSpeechToText)
