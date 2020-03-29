

document.querySelector('#btnGet')
    .addEventListener('input', (e) => {
        let nodes = document.querySelectorAll('.form-control');
        nodes.value = e.target.value;
    });