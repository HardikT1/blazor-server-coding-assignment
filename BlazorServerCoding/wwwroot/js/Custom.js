window.showModal = function (modalId) {
    $('#' + modalId).modal('show');
};

window.hideModal = function (modalId) {
    $('#' + modalId).modal('hide');
};