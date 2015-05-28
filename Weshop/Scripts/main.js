$(window).load(function () {
    
    return $('#checkoutButton').click(function (e) {
        console.log('click');
        var $this, url;
        e.preventDefault();

        $this = $(this).closest('a');
        url = this.data('targetUrl');
        return $.ajax({
            url: url,
            type: 'put',
            success: function (data) {
                $('.cart-count').html(data);
                return $this.closest('.cart-product').slideUp();
            }
        });
    });
});