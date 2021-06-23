const bodyParser = require("body-parser");
const express = require("express");
// const morgan = require("morgan");
// const path = require("path");
// const routes = require("../routes");
// const compression = require("compression");
// const logger = require("../services/Logger");
// const config = require("../config");

class ExpressLoader {
    constructor() {
        const app = express();

        // Serve static content
        // app.use( express.static( path.join( __dirname, "uploads" ) ) );

        // Set up middleware


        // Pass app to routes
        // routes(app);


        // Start application
        this.server = app.listen(3000, () => {
            console.log(`Express running, now listening on port 3000`);
        });
    }

    get Server() {
        return this.server;
    }


}

module.exports = ExpressLoader;