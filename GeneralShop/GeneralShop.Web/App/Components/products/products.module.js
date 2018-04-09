/// <reference path="C:\Users\tphmi\Desktop\New folder (3)\GeneralShop\GeneralShop\GeneralShop.Web\Assets/Admin/libs/angular/angular.js" />

(function () {
    angular.module('Shop.products', ['Shop.Common']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/App/Components/products/productListView.html",
            controller: "productListController"
        });
        $stateProvider.state('product_add', {
            url: "/product_add",
            templateUrl: "/App/Components/products/productAddView.html",
            controller: "productAddController"
        });
    }
})();