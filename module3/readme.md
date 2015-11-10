Putting everything together, Cordova App with Azure Mobile App
======================
In this module, we will be putting all the pieces together. We will be consuming the Mobile App API that we created in Module 1 and will be extending the Cordova App knowledge we learned in Module 2.

**Steps**
To follow along this module, you will need Ionic and Cordova npm packages installed and you will need a text editor of your choice. (Visual Studio Code, Full Visual Studio, Atom, Sublime)

Similar to Module 2 we will be creating an Ionic App using the Ionic CLI. This time we will be creating a blank Ionic app using the CLI. To do so, you will need to enter the following command in the Node.js command prompt

    ionic start movieapp blank

![movie app start](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/movieappstart.png)
Once the app is created, change the directory of your command line to be the new app directory and then execute the Ionic's platform add android command

    ionic platform add android

![Add Android](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/movieappplatformadd.png)

Now, Open up js/app.js file and change the angular module name to something more obvious for our app like

    var app = angular.module('movieapp', ['ionic'])

Now, lets define the responsibility of getting the data on the Controller -

    
app.controller('moviectrl', function($scope, $http){
  $scope.movies = [];
  
  $http.get('http://starwarsapi.azurewebsites.net/tables/movieItem').success(function(response){
     for (var index = 0; index < response.length; index++) {
          var movieItem = response[index];
          var movie =     {
                            id: movieItem.id, 
                            title: movieItem.title,
                            imageUrl: movieItem.imageUrl,
                            releaseDate: movieItem.releaseDate
                          };
                          
        $scope.movies.push(movie);  
        }
    
  });
  
});

What we are doing in the above snippet is that we are reading the data form the Mobile API end point and then getting all the data into a javascript array object.

Once that is done, we now need to go tell the HTML on how to show the information. 

Since we changed the app name earlier in this module, the first step is to tell the body tag on HTML on what the new app name is and what the controller that will execute our request is. That can be done using this update body tag

      <body ng-app="movieapp" ng-controller="moviectrl">
Now we will use an Ionic CSS Component called List. Using this component we will iterate over the list of movies using the ng-repeat directive and show the information

    <div class="list">
            <a class="item item-thumbnail-left" href="#" ng-repeat="movie in movies">
              <img src="{{movie.imageUrl}}">
              <h2>{{movie.title}}</h2>
              <p>{{movie.releaseDate}}</p>
            </a>
        </div>
Lets save all our changes and run the application using the following command

    ionic serve

If you notice carefully, in the chrome console. You will see an error logged stating that CORS requests are not valid. That is because we are currently running the app as a web application and web applications need CORS handling. While the app is bundled into an Android App, this problem goes away as the app is then run locally from the file system as opposed to a website.

To overcome this problem, we need to define a Proxy URL to access the service. To do so, open the **ionic.project** file and add a "proxies" section like below:

    {
  "name": "movieapp",
  "app_id": "",
  "proxies": [
    {
      "path": "/tables",
      "proxyUrl": "http://starwarsapi.azurewebsites.net/tables"
    }
   ]
}

What this is doing is that its saying whether the path starts with /tables, just redirect the request to http://starwarsapi.azurewebsites.net/tables . This way we are getting around the CORS issue by making the application think the data is coming from a local end point rather than a remote end point

To complete the CORS workaround, make sure you change $http.get call to call the local tables end point rather than the remote one -

    $http.get('http://localhost:8100/tables/movieItem').success(function(response){
Save all your changes and run the Ionic Serve command and you should see the application come up.

![Movie App Web](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/movieappweb.png)

> Note: If you are still seeing CORS error, terminate the current job
> and then restart the ionic serve command

That's it. You have now connected your API end point to your Cordova Application.

Let's not stop there, and lets take the next step in finding out how to best integrate third party JavaScript libraries in to your application.

If you notice carefully, the Release Date of each Movie Row is shown in Unix Time Stamp. Let's consider the case that we want that to be shown in a time ago format.

There is a fantastic library called [Moment.js](http://momentjs.com/) that simplifies this task for us. All we need to do is that we need verify if there is any Angular integration for moment.js as Ionic is built on top of AngularJS. 

And sure enough, a community contributor created a library called **Angular Moment** to expose directives in AngularJS. Here is the [link to the repository](https://github.com/urish/angular-moment)

If you read through Angular Moment carefully, the installation instructions are in the readme file 

To install Angular Moment we need to install the Angular-Moment package via bower, npm or Nuget. Bower is the number #1 choice for any client side components like this. So we will be using Bower -

    bower install angular-moment --save
Once Angular Moment library is installed, we then have to add the module as a dependency to our App Module. This is done in the app.js file like -

    var app = angular.module('movieapp', ['ionic', 'angularMoment'])

We now have to make sure that the HTML file can find the Angular Moment and Moment Libraries so lets add a script reference to them -

        <script src="lib/moment/moment.js"></script>
    <script src="lib/angular-moment/angular-moment.js"></script>

And finally, to use the directive all we need to do is just use the **am-time-ago** directive in Angular Moment.

                  <p am-time-ago="movie.releaseDate"></p>
And that's it. Make sure you run Ionic Serve to see the results in action.

![Movie App End](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/movieappend.png)

And when run on Android, 
![Movie App Android](https://github.com/vkoppaka/Azure-Cordova-Workshop/blob/master/assets/movieappandroid.png)