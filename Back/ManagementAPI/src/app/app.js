const express = require("express");
const morgan = require("morgan")

const router = require("../router/user.router")

const app = express();

app.use(morgan("dev"))

app.get("/", (req, res) => {
    res.send("PetAssitant in Express");
});


app.use("/api/v1", router)
module.exports = app;