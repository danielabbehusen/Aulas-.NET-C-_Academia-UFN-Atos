
// let resultado = 0;
// for (let i = 0; i <= 100; i++) {

//     resultado += i

// }

// window.alert(resultado)


function minhafuncao() {

    alert("Hello!")
}

function mostrarPares() {

    for (let i = 0; i <= 10; i++) {
        if (i % 2 == 0) {
            alert(i)
        }

    }
}

function mostrarSomatorio() {

    let resultado = 0;
    for (let i = 0; i <= 100; i++) {

        resultado += i

    }

    window.alert(resultado)
}

function deixarCaixaAlta() {
    let x = document.getElementById("nome");
    x.value = x.value.toUpperCase();

    // alert(x);
}

function idadeJuarez() {

    let x = document.getElementById("idade").value;
    let y = document.getElementById("nome").value;


    if (x >= 18) {
        alert(y + " É maior de idade")
    } else {
        alert(y + " É menor de idade")
    }

}


document.getElementById('soma').onclick = changeColorImpar;
function changeColorImpar() {
    document.body.style.color = "red"
    return false
}


function somaValores() {
    let valor1 = parseInt(document.getElementById("valor1").value)
    let valor2 = parseInt(document.getElementById("valor2").value)
    alert("A soma dos valores é: " + (valor1 + valor2))

    if ((valor1 + valor2) % 2 == 0) {
        document.getElementById("soma").style.background = 'red';

    } else {
        document.getElementById("soma").style.background = 'yellow';

    }


}