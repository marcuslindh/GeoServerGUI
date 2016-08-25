if (!Start) { var Start = {}; }

Start.LayerGroup = function () {
    function API(url, callback) {
        $.post("api/proxy", url, function (data) {
            try {
                callback(JSON.parse(data));
            } catch (e) {
                callback(data);
            }
        });
    }

    API("workspaces/Umea/layergroups.json", function () {
        var html = '';

        

    });





}