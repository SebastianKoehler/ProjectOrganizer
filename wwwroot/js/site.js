// ##################################################################
// Begin Index.cshtml
// ##################################################################

function checkInputValuesAndHandleCreateButton() {

    
    // Get the values of the input fields and the create project button
    const inputProjectNameValue = document.getElementById("projectNameInput").value;
    const inputProjectTechsValue = document.getElementById("projectTechInput").value;

    const createProjectBtn = document.getElementById("btnCreateProject");

    // Check if both of the input fields(project name & project techs) are empty.
    // When they are both empty, disable the create button
    if (inputProjectNameValue.trim() !== '' && inputProjectTechsValue.trim() !== '') {
        createProjectBtn.disabled = false;
    } else {
        createProjectBtn.disabled = true;
    }
}

function getInputValuesAndCreateNewProjectCard() {

    // Get the parent container and the values from the input fields
    const parentProjectOverview = document.getElementById("projectOverviewContainer");

    var inputProjectNameValue = document.getElementById("projectNameInput").value;
    var inputProjectDescriptionValue = document.getElementById("projectDescriptionInput").value;
    var inputProjectTechsValue = document.getElementById("projectTechInput").value;

    // Check if a project description is given, otherwise use a default value
    if (inputProjectDescriptionValue.trim().length === 0) {
        inputProjectDescriptionValue = "New project with a fantastic project description!";
    };

    // Create a new element
    var newProjectCard = document.createElement('div');

    // Give the new element a css-class to align it to the columns of the container
    newProjectCard.className = 'col'; 

    // Create the html structure and add it to the new element
    newProjectCard.innerHTML = `
        <div class="card text-center">
            <div class="card-header">
                ${inputProjectNameValue}
            </div>
            <div class="card-body">
                <p class="card-text">
                    ${inputProjectDescriptionValue}
                </p>
                <a href="#" class="btn btn-primary">Go to</a>
                <a href="#" class="btn btn-primary">Update</a>
                <a href="#" class="btn btn-primary">Delete</a>
            </div>
            <div class="card-footer text-muted">
                <span>${inputProjectTechsValue}</span>
            </div>
        </div>
    `;

    // Add the new element to the container
    parentProjectOverview.appendChild(newProjectCard);

    // Reset and clear the input fields
    document.getElementById("projectNameInput").value = "";
    document.getElementById("projectDescriptionInput").value = "";
    document.getElementById("projectTechInput").value = "";

    // Set the create project button back to disabled
    document.getElementById("btnCreateProject").disabled = true;
}

// ##################################################################
// End Index.cshtml
// ##################################################################

// ##################################################################
// Begin Privacy.cshtml
// ##################################################################

// Funktion zum Initialisieren des Drag & Drop-Verhaltens
function initDragAndDrop() {
    const cells = document.querySelectorAll('#kanbanTable td');

    cells.forEach(cell => {
        cell.setAttribute('draggable', 'true');

        cell.addEventListener('dragstart', handleDragStart);
        cell.addEventListener('dragover', handleDragOver);
        cell.addEventListener('drop', handleDrop);
    });
}

// Event-Handler für den Start des Drag-Vorgangs
function handleDragStart(event) {


}

// Event-Handler für das Drag-Over-Ereignis
function handleDragOver(event) {

}

// Event-Handler für das Drop-Ereignis
function handleDrop(event) {

}

// Drag & Drop initialisieren, wenn das DOM geladen ist
document.addEventListener('DOMContentLoaded', initDragAndDrop);

function createTicket() {
    // Neues Ticket-Element erstellen
    var newTicket = document.createElement('div');
    newTicket.textContent = 'New Ticket'; // Hier kannst du den Textinhalt des Tickets festlegen
    newTicket.id = "ticket";

    // Das erste <td> Element in der ersten Zeile der Tabelle auswählen
    var firstColumn = document.querySelector('#kanbanTable tbody tr:first-child td:first-child');

    // Das neue Ticket-Element der ersten Spalte hinzufügen
    firstColumn.appendChild(newTicket);
}

// ##################################################################
// End Privacy.cshtml
// ##################################################################