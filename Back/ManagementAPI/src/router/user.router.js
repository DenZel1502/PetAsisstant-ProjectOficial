const router = require("express").Router();

//Gestion de datos x usuario

//Mostrar información de usuario por ID
router.get("/users",  (req, res) => {
    res.send("Primera Ruta");
});

//Modificar Información de Usuario 
router.post("/users",  (req, res) => {
    res.send("Primera Ruta");
});

//Eliminación logica de usuario(Update)
router.put("/users",  (req, res) => {
    res.send("Primera Ruta");
});


module.exports = router;
