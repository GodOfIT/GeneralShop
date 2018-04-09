/// <reference path="C:\Users\tphmi\Desktop\New folder (3)\GeneralShop\GeneralShop\GeneralShop.Web\Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('Shop', ['Shop.products','Shop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/App/Components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();