$(document).ready(function() {
    // Parte de este código pertenece a la documentación oficial de Bootstrap para Modal. https://getbootstrap.com/docs/5.3/components/modal/.
    const modal1 = document.getElementById('modal1')
    if (modal1) {
        modal1.addEventListener('show.bs.modal', event => {
            // Botón que llamó al modal.
            const button = event.relatedTarget
            
            // Obtiene la información de Id del item.
            const id = button.getAttribute('data-bs-id')

            const eliminarForm = document.getElementById("eliminarForm")
            eliminarForm.setAttribute("action", eliminarForm.getAttribute("action") + "/" + id)
        })
    }
})