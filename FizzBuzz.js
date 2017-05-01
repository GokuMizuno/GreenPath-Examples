angular.module('fizzbuzz', [])
    
    
    .factory("Counter", function() {
      var increment = function() {
        service.number++;
        if (service.number % 15 === 0) {
          //any way to set $scope.display directly here?
          service.display = "FIZZBUZZ"
        }
        else if (service.number % 3 === 0) {
          service.display =  "FIZZ"
        }
        else if (service.number % 5 === 0) {
          service.display =  "BUZZ"
        }else{
          service.display = service.number
        }
      }
      var service = {
        increment: increment,
        number:0,
        display: 'Click to start'
      }
      return service;
    })
    
    .controller("FizzBuzz", function($scope, Counter) {
      // can reference method and data from the service
      $scope.Counter = Counter;
    })