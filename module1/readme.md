Creating Azure Mobile App
======================
In this module, we will be creating an Azure Mobile App using the Azure Portal. If you have not signed up for an Microsoft Azure account yet, please do so at [http://azure.com](http://azure.com)

**Steps**
To follow along this module, you will need Visual Studio 2015 and Azure SDK 2.6 or above:

Go to [https://portal.azure.com](https://portal.azure.com) and login with your Microsoft Account. You should now see the Azure Portal's Dashboard
![Azure Portal Dashboard](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp1.png)
Click on "New" in the left side navigation menu and select Web + Mobile and inside that select **Mobile App**
![Azure Mobile App](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp2.png)
In the create a Mobile App Screen, enter the app name, pick your Azure Subscription, Resource Group and App Service Plan.
![Azure App Service Plan](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp3.png)
Click Create once the selections are made and your Mobile App will be Deployed
![App Deployed](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp4.png)
Once the Deployment is complete, you will be presented with Azure Mobile App Dashboard Page. We now need to setup a database that goes along with our Mobile App where we can store our information. 
To create a new database, click on All Settings, under Mobile Section of settings, click on Get Started, and under Quickstart section click on HTML/Javascript. 
The HTML/Javascript Quickstart template has a little indicator on the top which tells us that we need to create a database.
![HTMLJSQuickStart](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp5.png)
You will then be on a "Add data connection" screen. On this screen, please pick your SQL Database and Connection String Settings and click OK
![Add Data Connection](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp6.png)
![New Database settings](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp7.png)
![Connection String Settings](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp8.png)
The connection string that the Mobile App uses is a mixture of the Server and UserName and Password. 
Once all the selections are made, click on Create, and your Data Connection will be created
![Data Connection Create](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp9.png)
And you should see your Data Connections in your Data Connections Window.
![Data Connections](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp10.png)

> Please note, if you don't see your Data Connections Right away, please
> refresh your screen. There seems to be a bug in Azure Portal where
> Data connections are not properly associated in few scenarios.

Now that we have created the App and the database that goes with it. We need to feed some data into the app. If you go back to the Quickstart screen of our Mobile App, you will see an option to **Download and run your server project**. If you click the download button, your server project should be downloaded.

> Unzip the contents of the zip file to a more convenient location and
> make sure you unblock the zip file before you do so to not run into
> any permission issues

Open up the Visual Studio Studio Solution and make the following modifications to the application. -
Since we are storing movie information we will try to seed the database with Movie data. 

Copy the contents of MovieItem class from the [Github Repository](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/module1/starwarsapi2_Runtime/starwarsapi2Service/DataObjects/MovieItem.cs)

Now copy the contents of the MovieItemController class from the [Github Repository](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/module1/starwarsapi2_Runtime/starwarsapi2Service/Controllers/MovieItemController.cs)
Finally open the Startup.MobileApp.cs class and copy the contents from the [Github Repository](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/module1/starwarsapi2_Runtime/starwarsapi2Service/App_Start/Startup.MobileApp.cs)

> Note: You may have to change the context name in your Controller and
> Startup Classes depending on what your called your mobile app.

Build the solution and make sure it runs by just hitting **ctrl + F5**

Now that we have the Mobile App running, the next task is to publish the Mobile App to Azure.

Open the Visual Studio Solution and Click on Build->Publish. You should be presented with a dialog similar to the one below
![Publish Dialog](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp12.png)
In the Publish Window, Click Microsoft Azure Web App and from the subsequent screen select the web app you created at the beginning of this module.
![Pick App](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp13.png)
You will then be presented with connection settings, click on Validate Connection String to make sure you have the correct publish profile.
![Publish Profile](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp14.png)
On the next screen, make sure the **MS_TableConnectionString** gets replaced with the Database connection string we created earlier. 

![Connection String](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp15.png)
And that's it, you should now see your API being available on Azure Web Apps
![enter image description here](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/azuremobileapp16.png)

> NOTE: We are using a Blob Container to host the images, if time
> permits, please explore creating your own blob storage to get an idea
> on how to store images on Azure