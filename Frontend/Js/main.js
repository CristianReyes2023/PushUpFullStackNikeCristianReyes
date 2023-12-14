async function camisetas() {
    let reqData = await fetch(`http://localhost:5020/nike/Producto`);
    let respJson = await reqData.json();
    camiseta.forEach(boton => boton.addEventListener("click", () => {
        try {
            const contenedorProductos = document.querySelector("#productss");
            contenedorProductos.innerHTML = "";
            camiseta.forEach(boton => boton.addEventListener("click", () => {
                aside.classList.remove("aside-visible");
            }))
            respJson.forEach(producto => {

                const div = document.createElement("div");
                div.classList.add("producto");
                div.innerHTML = /*html*/`
            <img class="producto-imagen" src="${producto.imagen}" alt="${producto.nombre}">
            <div class="producto-detalles">
                <h3 class="producto-titulo">${producto.nombre}</h3>
                <p class="producto-precio">$${producto.precio}</p>
                <button class="producto-agregar" id="${producto.id}">Agregar</button>
            </div>
        `;

                contenedorProductos.append(div);
            });
        } catch (error) {
            console.error('Error al obtener datos:', error);
        }

        actualizarBotonesAgregar();
    }))
}
camisetas();