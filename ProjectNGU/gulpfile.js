var gulp = require("gulp");
var merge = require("merge-stream");
var rimraf = require("rimraf");

// Dependency Dirs
var deps = {
    "bootstrap": {
        "dist/**/*": ""
    }
};

gulp.task("clean", function (cb) {
    return rimraf("wwwroot/vendor/", cb);
});


gulp.task("scripts", function () {

    var streams = [];

    for (var prop in deps) {
        console.log("Prepping Scripts for: " + prop);
        for (var itemProp in deps[prop]) {
            streams.push(gulp.src("node_modules/" + prop + "/" + itemProp)
                .pipe(gulp.dest("wwwroot/vendor/" + prop + "/" + deps[prop][itemProp])));
        }
    }

    return merge(streams);

});

gulp.task("default", ["clean", "scripts"]);