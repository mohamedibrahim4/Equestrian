
//function RemainingCost() {
//    debugger;
//    //var PaidCost = $('#PaidCost').val().trim();
//    //var Discount = $('#Discount').val().trim();
//    //var PriceCost = $('#PriceCost').val().trim();
//    //var RemainingCost = parseInt(PriceCost) - (parseInt(Discount) + parseInt(PaidCost));
//    //$('#RemainingCost').html(RemainingCost);

//    const PaidCost = document.getElementById('PaidCost');
//    const Discount = document.getElementById('Discount');
//}
function sum() {
    var PaidCost = document.getElementById('PaidCost').value;
    var Discount = document.getElementById('Discount').value;
    var PriceCost = document.getElementById('PriceCost').value;
    if (PaidCost == "")
        PaidCost = 0;
    if (Discount == "")
        Discount = 0;
    if (PriceCost == "")
        PriceCost = 0;
    var RemainingCost = parseInt(PriceCost) - parseInt(Discount) - parseInt(PaidCost);
    if (!isNaN(RemainingCost)) {
        document.getElementById('RemainingCost').value = RemainingCost;
    }
}