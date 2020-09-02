//Exercise 1:Write a JavaScript function
//that reverses a number.
function reverse_num(n){
	var s = "";
	n=n.String(n);
	for(var i=0; i<len(n); i++){
		for(var p=len(n-1);i<len(n);p--){
			s[i]=n[p];
		}
	}
	n=Number(s);
	return n;
}

//Exercise 2: Write a JavaScript function that accepts a 
//number as a parameter and check the number is prime or not.
function isPrime(n){
	n = Number(n);
	if (n==1){
		return	false;
	} else if(n==2){
		return true;
	} else{
		for (var x=2; x<n; x++){
			if (n%x==0) {
				return false
			}
	}
	return true;
	}	
}

//Exercise 3: Write a JavaScript function that accepts two arguments, 
//a string and a letter and the function will count the 
//number of occurrences of the specified letter within the string.
function countEx(s,l){
	var c=0;
	for(var i=0; i<len(s);i++){
		if(s[i]==l){
			c++;
		}
	}
	return c;
}
