redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51LmKXOAjAcWJ2RFGvntAfFXYBvTb9p4MmbZPrSbAuK6LyfaUA7Aq0N86Jd5F538jYAyRdIhp6kUb7OFvjiIT3aed00wuCn6wQ8');
    stripe.redirectToCheckOut({
        sessionId: sessionId
    });
};