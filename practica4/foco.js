window.addEventListener('load', function () {
    foco();
});

function foco() {
    const img = document.createElement("img");
    img.classList.add('foco');
    img.setAttribute('src', 'images/foco-apagado.jpg');

    img.addEventListener('click', () => {

        if (img.src.indexOf("apagado") > 0) {

            img.setAttribute('src', 'images/foco-prendido.jpg');
            document.body.classList.remove('oscuridad');
            document.body.classList.add('luz');
        } else {

            img.setAttribute('src', 'images/foco-apagado.jpg');
            document.body.classList.remove('luz');
            document.body.classList.add('oscuridad');
        }
    });

    document.body.appendChild(img);
}

