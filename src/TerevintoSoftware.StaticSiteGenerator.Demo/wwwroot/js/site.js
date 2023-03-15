$(function () {
    $("#changeLanguageBtn").click(function () {
        const currentUrl = window.location.pathname;

        if (currentUrl.startsWith("/en/")) {
            const esUrl = currentUrl.replace("/en/", "/es/");

            window.location.href = window.location.href.replace(currentUrl, esUrl);
        }
        else if (currentUrl.startsWith("/es/")) {
            const enUrl = currentUrl.replace("/es/", "/en/");

            window.location.href = window.location.href.replace(currentUrl, enUrl);
        }
        else if (currentUrl === "/") {
            window.location.href = window.location.href + "es/index";
        }
    });
})