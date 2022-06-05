// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $("#changeLanguageBtn").click(function () {
        const currentUrl = window.location.pathname;

        if (currentUrl.startsWith("/en/")) {
            const esUrl = currentUrl.replace("/en/", "/es/");

            window.location.href = window.location.href.replace(currentUrl, esUrl);
        }

        if (currentUrl.startsWith("/es/")) {
            const enUrl = currentUrl.replace("/es/", "/en/");

            window.location.href = window.location.href.replace(currentUrl, enUrl);
        }

        if (currentUrl === "/index.html") {
            window.location.href = window.location.href.replace("/index.html", "/es/index.html");
        }
    });
})