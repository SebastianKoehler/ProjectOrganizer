
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
