
startModule.controller("leagueController", function ($scope, bootstrappedLeagues) {
    $scope.leagues = bootstrappedLeagues.leagues;
});