var email = "";
var textArea = "";

function submitButton() {

    this.email = document.getElementById("emailInput").value;
    this.textArea = document.getElementById("textInput").value;

    console.log("Email: " + email)
    console.log("Mensagem: " + textArea)

    if (email != "" && textArea != "") {
        alert("Mensagem enviada com sucesso.")
    } else {
        alert("Por favor, preencha os campos 'Email' e 'Mensagem'.")
    }

    this.pageRefresh();
}

function pageRefresh() {
    location.reload();
}