// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const buttons = document.querySelectorAll('.carousel-button');
const carouselImage = document.getElementById('carousel-image');

buttons.forEach(button => {
    button.addEventListener('mouseover', () => {
        const newImage = button.getAttribute('data-image');
        carouselImage.src = newImage;
    });
});

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