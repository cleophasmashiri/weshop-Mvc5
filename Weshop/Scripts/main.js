$(window).load(function () {
    
    return $('a[data-target]').click(function (e) {
        console.log('click');
        var $this, url;
        e.preventDefault();
        $this = $(this);
        url = $this.data('addurl');
        return $.ajax({
            url: url,
            type: 'put',
            success: function (data) {
                return $('.cart-count').html(data);
            }
        });
    });
});