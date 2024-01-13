function JSAlert() {
    alert("Hello");
}

function AddTableRow(elem, firstname, lastname) {
    let row = document.createElement("tr");

    let cell1 = document.createElement("td");
    let cell2 = document.createElement("td");
    cell1.innerText = firstname;
    cell2.innerText = lastname;

    row.append(cell1);
    row.append(cell2);
    elem.append(row);
} 