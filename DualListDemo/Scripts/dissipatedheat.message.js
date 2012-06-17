// DissipatedHeat messaging JS functions.
// http://www.dissipatedheat.com

function showSuccess(data) {
	var json = $.parseJSON(data.responseText);

	showSuccessStr(json.message);
}

function showSuccessStr(message, forceReload) {
	jQuery('body').showMessage({
		'thisMessage': [message],
		'className': 'success',
		'opacity': 95,
		'displayNavigation': false,
		'autoClose': true,
		'delayTime': 6000,
		'onClose': forceReload ? function () { window.location.replace(window.location); } : function () { }
	});
}

function showFail(data) {
	var json = $.parseJSON(data.responseText);

	showFailStr(json.message);
}

function showFailStr(message, forceReload) {
	jQuery('body').showMessage({
		'thisMessage': [message],
		'className': 'fail',
		'opacity': 95,
		'displayNavigation': false,
		'autoClose': true,
		'delayTime': 6000,
		'onClose': forceReload ? function () { window.location.replace(window.location); } : function () { }
	});
}

function showNotification(data) {
	var json = $.parseJSON(data.responseText);

	showNotificationStr(json.message);
}

function showNotificationStr(message, forceReload) {
	jQuery('body').showMessage({
		'thisMessage': [message],
		'className': 'notification',
		'opacity': 95,
		'displayNavigation': false,
		'autoClose': true,
		'delayTime': 6000,
		'onClose': forceReload ? function () { window.location.replace(window.location); } : function () { }
	});
}

function showException(data) {
	var json = $.parseJSON(data.responseText);

	showExceptionStr(json.message);
}

function showExceptionStr(message, forceReload) {
	jQuery('body').showMessage({
		'thisMessage': [message],
		'className': 'exception',
		'opacity': 95,
		'displayNavigation': false,
		'autoClose': true,
		'delayTime': 6000,
		'onClose': forceReload ? function () { window.location.replace(window.location); } : function () { }
	});
}

function showMessage(json) {

	switch (json.type) {
		case 'success': showSuccessStr(json.message, json.forceReload); break;
		case 'fail': showFailStr(json.message, json.forceReload); break;
		case 'notification': showNotificationStr(json.message, json.forceReload); break;
		case 'exception': showExceptionStr(json.message, json.forceReload); break;
	}
}