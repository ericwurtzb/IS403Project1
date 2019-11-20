var answer = [];
var counter = [];

for (iCount = 0; iCount < 10; iCount++) {
    counter[iCount] = 1;
    answer[iCount] = "";
}


function response(num) {
    document.getElementById("btn" + num).style.display = "none";
    var newForm = "<form action='SubmitForm' method='post'><textarea id='textarea" + num + "' name='answer' + placeholder='Respond here...'></textarea> <br /> <input type='button' class='btn btn-primary btn - sm' onclick='submitAnswer(" + num + ")' value='Save' /></form>";
    document.getElementById("output" + num).innerHTML = newForm;
}

function submitAnswer(num) {
    document.getElementById("btn" + num).style.display = "inline-block";
    answer[parseInt(num)] += "Answer " + counter[parseInt(num)] + ": " + document.getElementById("textarea" + num).innerHTML + "<br>";
    document.getElementById("output" + num).innerHTML = answer[parseInt(num)];
    counter[parseInt(num)]++;
}