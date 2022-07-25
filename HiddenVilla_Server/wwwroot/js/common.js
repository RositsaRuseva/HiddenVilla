window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operation Successful")
    }
    if (type === "error") {
        toastr.error(message, "Operation Failed")
    }
}
window.ShowSweetAlert = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success notification',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error notification',
            message,
            'error'
        )
    }
}

function ShowDeleteConfirmationModal()
{
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal()
{
    $('#deleteConfirmationModal').modal('hide');
}
