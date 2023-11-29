const { Sequelize, Model, DataTypes } = require("sequelize");

const sequelize = new Sequelize("PetDataBase", "root", "", {
    host: "localhost",
    dialect: "mysql",
    port: 3306,
});

async function testConnection() {
try {
    await sequelize.authenticate();
    console.log("All Good!!")
} catch (err) {
    console.error("All Bad!!", err)
}
}

testConnection();