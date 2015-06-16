var startModule = angular.module("startModule", ['ngRoute'])
    .config(function($routeProvider, $locationProvider) {
    $routeProvider.when('/Start/League', { templateUrl: '/Templates/League.html', controller: 'LeagueController' });
    $routeProvider.when('/Start/Team', { templateUrl: '/Templates/Team.html', controller: 'TeamController' });
    $locationProvider.html5Mode(true);
});