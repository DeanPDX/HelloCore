$(document).ready(function() { 
    // When the user clicks the "get contacts" button, retrieve contacts from our web API and display them.
    $('#btn-get-contacts').click(function() {
        $.get('/api/contacts', function(data) {
            // Note: don't really do this either.  Use a templating engine or SPA framework
            $('#contacts').html('<ul id="contacts-group" class="list-group"></ul>');
            var contactsGroup = $('#contacts-group');
            for (var i = 0; i < data.length; i++) {
                contactsGroup.append('<li class="list-group-item"><span class="glyphicon glyphicon-user"></span> ' + data[i].firstName + ' ' + data[i].lastName + '</li>');
            }
        });
    });
});