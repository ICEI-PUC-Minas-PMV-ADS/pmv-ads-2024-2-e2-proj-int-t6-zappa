const { Router } = require("express");
const router = Router();

// get post put delete

router.get("/usuarios", (req, res) => {
    res.send("Estamos listando todos os usuários")
});

router.post("/usuarios", (req, res) => {
    res.send("Chegou aqui. Estamos criando um novo atendimento")
})

router.put("/usuarios/:id", (req, res) => {
    const { id } = req.params;
    res.send("Chegou aqui. Estamos atualizando um novo atendimento" + id)
});

router.delete("/usuarios/:id", (req, res) => {
    const { id } = req.params;
    res.send("Chegou aqui. Estamos atualizando um novo atendimento" + id)
});

module.exports = router;