$(function () {
    $("#changeLanguageBtn").click(function () {
        const currentUrl = window.location.href;

        if (currentUrl.endsWith("?culture=en")) {
            window.location.href = window.location.href.replace("?culture=en", "?culture=es");
        } else if (currentUrl.endsWith("?culture=es")) {
            window.location.href = window.location.href.replace("?culture=es", "?culture=en");
        } else {
            window.location.href = window.location.href + "?culture=es";
        }
    });
})