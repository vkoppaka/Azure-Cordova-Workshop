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
![Website](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/IonicServed.png)
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