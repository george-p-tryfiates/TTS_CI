//Exercise 1//Write a JavaScript function to clone an array.
function cloneArray(arg){
	var clonedArray = [...arg];
	return clonedArray;
}
//Exercise 2
//Write a simple JavaScript program to join all elements of the following array into a string.
myColor = ["Red", "Green", "White", "Black"];
function(arg){
	var s =	arg.join('');
	return s;
}

//Exercise 3
//Write a JavaScript program to compute the sum and product of an array of integers.
function sumAndProduct(arg){
	var sum = arg.reduce(function(a, b){
        return a + b;
        }, 0);
	var product = arg.reduce(function(a,b){
		return a*b;
	}, 0);
	return (sum,product);
}