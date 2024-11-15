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

//Navbar configurações
document.addEventListener('DOMContentLoaded', () => {
    const menuToggle = document.getElementById('menu-toggle');
    const navItens = document.getElementById('nav-itens');

    // Função para alternar a classe 'active'
    const toggleMenu = () => {
        navItens.classList.toggle('active');
    };

    menuToggle.addEventListener('click', toggleMenu);

    const menuLinks = document.querySelectorAll('.nav-itens a');
    menuLinks.forEach(link => {
        link.addEventListener('click', () => {
            navItens.classList.remove('active');
        });
    });

    // Fechar o menu ao clicar fora dele
    document.addEventListener('click', (event) => {
        const isClickInsideMenu = navItens.contains(event.target);
        const isClickOnToggle = menuToggle.contains(event.target);

        if (!isClickInsideMenu && !isClickOnToggle) {
            navItens.classList.remove('active');
        }
    });
});

// Script que identifica qual página está ativa para deixar marcado na navbar

document.addEventListener('DOMContentLoaded', () => {
    const currentLocation = window.location.pathname;
    const menuLinks = document.querySelectorAll('.nav-itens a');

    menuLinks.forEach(link => {
        if (link.href.includes(currentLocation)) {
            link.classList.add('active');
        }
    });
});