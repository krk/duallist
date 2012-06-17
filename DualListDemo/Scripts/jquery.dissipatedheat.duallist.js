/*

jQuery DualList widget

Kerem KAT
http://www.dissipatedheat.com

*/
; (function ($) {
    $.widget('ui.duallist', {

        /* iki adet ul içeren bir div'den çağrılır. */
        options: {
            connectWith: 'connectedSortable',
            update: function (containerId, listId, elementId) {

            }
        },

        ids: function () {
            var that = this;
            return {
                containerId: that.element.attr('id'),
                orig1: that.list1_orig_ids,
                orig2: that.list2_orig_ids,
                new1: that.list1.sortable('toArray'),
                new2: that.list2.sortable('toArray')
            };
        },

        // Set up the widget
        _create: function () {
            var that = this;
            that.list1 = $('ul:first', that.element);
            that.list2 = $('ul:last', that.element);

            that.list1.sortable({
                connectWith: '.' + that.options.connectWith,
                dropOnEmpty: true,
                placeholder: 'ui-state-placeholder',
                beforeStop: function (event, ui) { if (ui.item.parent('ul').attr('id') == that.list1.attr('id')) return false; },
                cursor: 'crosshair',
                update: function (event, ui) {
                    if (that.options.update != null && that.options.update != '') {
                        that.options.update(that.element.attr('id'), 1, ui.item.attr('id'));
                    }
                },
                start: function (e, ui) {
                    $(ui.placeholder).slideUp();
                },
                change: function (e, ui) {
                    $(ui.placeholder).hide().slideDown();
                }
            }).disableSelection();

            that.list2.sortable({
                connectWith: '.' + that.options.connectWith,
                dropOnEmpty: true,
                placeholder: 'ui-state-placeholder',
                beforeStop: function (event, ui) { if (ui.item.parent('ul').attr('id') == that.list2.attr('id')) return false; },
                cursor: 'crosshair',
                update: function (event, ui) {
                    if (that.options.update != null && that.options.update != '') {
                        that.options.update(that.element.attr('id'), 2, ui.item.attr('id'));
                    }
                },
                start: function (e, ui) {
                    if (ui.item.parent('ul').attr('id') != that.list2.attr('id')) {
                        $(ui.placeholder).slideUp();
                    }
                },
                change: function (e, ui) {
                    if (ui.item.parent('ul').attr('id') != that.list2.attr('id')) {
                        $(ui.placeholder).hide().slideDown();
                    }
                }
            }).disableSelection();

            that.list1_orig_ids = that.list1.sortable('toArray');
            that.list2_orig_ids = that.list2.sortable('toArray');
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this);
        }
    });
}(jQuery));