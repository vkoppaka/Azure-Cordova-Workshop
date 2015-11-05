Azure Cordova Workshop
======================

**Installations**
To follow along in this workshop you will need the following tools and software to be installed:

 1. NodeJS: [64 bit installer](https://nodejs.org/dist/v4.2.2/node-v4.2.2-x64.msi), [32 bit installer](https://nodejs.org/dist/v4.2.2/node-v4.2.2-x86.msi)
 2. Git: [64 bit installer](https://github.com/git-for-windows/git/releases/download/v2.6.2.windows.1/Git-2.6.2-64-bit.exe), [32 bit installer](https://github.com/git-for-windows/git/releases/download/v2.6.2.windows.1/Git-2.6.2-32-bit.exe)
 3. Android SDK: [Android Studio and SDK](https://developer.android.com/sdk/index.html#win-bundle)
 4. Install Cordova tools: `npm install -g cordova`
 5. Install Ionic CLI: `npm install -g ionic`
 6. Install Bower: `npm install -g bower`

**Tools Required**

 7. Visual Studio Code: [download here](https://code.visualstudio.com/) (any editor or full visual studio with cordova tools installed will also work fine)
 8. Microsoft Azure Account: [Sign up here](https://azure.microsoft.com/en-us/)

A little Ionic refresher
------------------------
To know what version of Ionic you installed, open up Node.js command prompt and type in:

    ionic -v
You should see something like:
![Ionic version](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicversion.png)
 To know what versions of all Ionic dependencies you have installed:
 
    ionic info
You should see something like:
![Ionic Info](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicinfo.png)
 Workshop 1
----------
In the first workshop we will create a simple cordova application using the Ionic framework.
To get started, launch the Node.js command prompt and change the directory to your current working directory. 

    cd <path\foldername>

To create a project using ionic we will be using the *ionic start* command. In the directory, enter the following command.

    ionic start cordovatest

![Ionic Start Test](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicstarttest.png)
and you would see application getting created via the command line.
![Ionic Start End](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicstarttestend.png)
    
All Cordova Applications are HTML 5 applications which can just be run via the browser and the Ionic framework is no different. To see how the application that we just created looks like in a browser, type 

    ionic serve

![Ionic Serve](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicserve.png)

Ionic is now going to ask you how to start the serve command and you would be picking locahost (option 4)
![enter image description here](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicserved.png)
You should now see your Cordova Mobile Application in your web browser
![Ionic Starter App](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/ionicstarterapp.png)
Now, let us try to run the application on a Mobile Emulator. To do that, we should add Android specific platform code first using the following command -

    ionic platform add android
  
  ![Android Add Platform](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/platformaddandroid.png)
  All that is left to do now is to build and run the android application. To build the Android application type the following command 
  
    ionic build android
  
  To run the Android application type the following command
  
    ionic emulate android
   
   ![Android Starting](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/androidstarting.png)
   ![Android App](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/testandroidapp.png)