(function(){
var app = angular.module('movieapp', ['ionic', 'angularMoment'])

app.controller('moviectrl', function($scope, $http){
  $scope.movies = [];
  
  $http.get('http://localhost:8100/tables/movieItem').success(function(response){
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

app.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    if(window.cordova && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
    }
    if(window.StatusBar) {
      StatusBar.styleDefault();
    }
  });
})
})();
