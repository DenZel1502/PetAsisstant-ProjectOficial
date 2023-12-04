const { Model, DataTypes } = require("sequelize");
const sequelize = require('../db');

async function testConnection() {
try {
    await sequelize.authenticate();
    console.log("All Good!!")
} catch (err) {
    console.error("All Bad!!", err)
}
}

testConnection();