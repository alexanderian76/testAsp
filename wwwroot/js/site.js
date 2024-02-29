// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function getPhones() {
    fetch("Home/GetPhones").then(res => res.text().then(txt => $("#title").html(txt)))
}

function createPhoneWithRandomPrice() {
    let phones = [
        { Code: "1", Value: "value1" },
        { Code: "5", Value: "value2" },
        { Code: "15", Value: "value4" },
        { Code: "10", Value: "value3" },
        { Code: "20", Value: "value5" }
    ]
    fetch("Home/CreatePhones", { method: "POST", body: JSON.stringify(phones), headers: { "Content-Type": "application/json" } }).then(res => res.text().then(txt => $("#title").html(txt)))
}
