var loadingOverlay = (function () {
    var loadingOverlay = {};

    loadingOverlay.show = function () {
        var loadingDiv = document.createElement("div");
        loadingDiv.className = "loading style-2";
        loadingDiv.id = "loading-container";
        var wheelDiv = document.createElement("div");
        wheelDiv.className = "loading-wheel";
        loadingDiv.appendChild(wheelDiv);
        document.body.appendChild(loadingDiv);
    }

    loadingOverlay.hide = function () {
        var loadingContainer = document.getElementById("loading-container");
        if (loadingContainer) {
            loadingContainer.remove();
        }
    }

    return loadingOverlay;
})();