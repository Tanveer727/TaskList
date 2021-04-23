
document.addEventListener('DOMContentLoaded', function () {


    if ('serviceWorker' in navigator) {
        window.addEventListener('load', function () {
            navigator.serviceWorker.register('/pwa-serviceworker.js').then(function (registration) {
                // Registration was successful
                console.log('ServiceWorker registration successful with scope: ', registration.scope);
            }, function (err) {
                // registration failed :(
                console.log('ServiceWorker registration failed: ', err);
            });
        });


        navigator.serviceWorker.addEventListener('message', event => {
            alert(event.data.msg, event.data.url);
        });

    }



}, false);

    



