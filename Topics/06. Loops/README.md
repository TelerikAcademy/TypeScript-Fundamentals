<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Loops
## Execute Blocks of Code Multiple Times
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic00.png" style="top:48%; left:58.48%; width:44.15%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->

<div class="signature">
	<p class="signature-course">TypeScript Fundamentals</p>
	<p class="signature-initiative">Telerik School Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>



<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [What is a Loop?](#/whatisloop)
- Loops in TypeScript
  - [`while` loop](#/while)
  - [`do` … `while` loop](#/dowhile)
  - [`for` loop](#/for)
  - [`for in` loop](#/foreach)
- Special loop operators
  - [`break`, `continue`](#/breakcontinue)
- [Nested loops](#/nestedloops)  

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic02.png" style="top:19.39%; left:58.26%; width:42.96%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->



<!-- section start -->
<!-- attr: { id:'whatisloop', class:'', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="whatisloop"></a>What Is Loop?
- A `loop` is a control statement that allows repeating execution of a block of statements
  - May execute a code block fixed number of times
  - May execute a code block while given condition holds
  - May execute a code block for each member of a collection
- Loops that never end are called an `infinite loops`



<!-- section start -->
<!-- attr: { id:'while', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # <a id="while"></a>Using while(…) Loop -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic03.png" style="top:45%; left:30%; width:45%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# How To Use While Loop?
- The simplest and most frequently used loop

```javascript
while (condition) {
    statements;
}
```

- The repeat condition
  - Returns a boolean result of `true` or `false`
  - Also called `loop condition`



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# While Loop – How It Works?

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/while-loop.png" style="top:15%; left:10%; width:80%; z-index:-1; border-radius: 15px;" /> -->




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# While Loop – _Example_

```javascript
var counter: number = 0;
var message: string;

while (counter < 10) {
    message = `Count: ${counter}`;
    console.log(message);
    counter++;
}
```

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic-counter.png" style="top:53%; left:5%; width:40%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # While -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic05.png" style="top:40%; left:30%; width:40%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Sum 1..N – _Example_
- Calculate and print the sum of the first N natural numbers

```javascript
let limit: number = 10;
let currentNumber: number = 1;
let sum: number = 1;

console.log(`Initial sum ${sum}`);

while (currentNumber < limit) {
    currentNumber++;
    sum += currentNumber;
    console.log(`+${currentNumber}`);
}

console.log(`Final sum ${sum}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Calculating Sum 1..N -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/Sum)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic06.png" style="top:55%; left:33%; width:35%; z-index:-1; border:2px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Prime Number – _Example_
- Checking whether a number is prime or not

```javascript
let number: number = 4;
let divider: number = 2;
let maxDivider: number = Math.sqrt(number);
let isPrime: boolean = true;

while (isPrime && (divider <= maxDivider)) {
    if (number % divider == 0) {
        isPrime = false;
    }

    divider++;
}

console.log(`Is ${number} prime? - ${isPrime}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Checking whether a number is Prime -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/IsPrime)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic07.png" style="top:44.96%; left:70%; width:28%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic08.png" style="top:44.96%; left:-4%; width:35%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Using `break` Operator
- `break` operator exits the inner-most loop

```javascript
// Calculate n! = 1 * 2 * ... * n
let n: number = 4;
let result: number = 1;

while (true) {
    if (n == 1) {
        break;
    }

    result *= n;
    n--;
}

console.log(`${n}! = ${result}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Calculating Factorial -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/FactorialBreak)

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic09.png" style="top:55%; left:33%; width:35%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->



<!-- section start -->
<!-- attr: { id:'dowhile', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # <a id="dowhile"></a>do { … } while (…)Loop -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic10.png" style="top:45%; left:30%; width:40%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Do-While Loop
- Another loop structure is:

```javascript
do {
    statements;
}
while (condition);
```

- The block of statements is repeated
  - While the boolean loop condition holds
- The loop is executed **at least once**



<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic11.png" style="top:16%; left:83%; width:15%; z-index:1; border: 1px solid black; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Do-While Statement

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/dowhile-loop.png" style="top:15%; left:10%; width:70%; z-index:-1; border-radius: 15px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # do { … } while
## _Examples_ -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic12.png" style="top:50%; left:34%; width:30%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Factorial – _Example_
- Calculating N factorial

```javascript
let n: number = 4;
let factorial: number = 1;

do {
    factorial *= n;
    n--;
} while (n > 0)

console.log(`${n}! = ${factorial}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Factorial (do ... while) -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/FactorialDoWhile)

<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Product[N..M] – _Example_
- Calculating the product of all numbers in the interval [n..m]:

```javascript
let n = 4;
let m = 10;
let number = n;
let product = 1;

do {
    product *= number;
    number++;
} while (number <= m)

console.log(`product[${n}..${m}] = ${product}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Product of the Numbers in the Interval [n..m] -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/Product)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # for Loops -->

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic15.png" style="top:45%; left:20%; width:60%; z-index:-1; border-radius: 15px;" /> -->


<!-- attr: { id:'for', class:'', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="for"></a>For Loops
- The typical `for` loop syntax is:

```javascript
for (initialization; condition; update) {
    statements;
}
```

- Consists of
  - `Initialization` statement
  - `Boolean check` expression
  - `Update` statement
  - `Loop` body block



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Initialization Expression

```javascript
for (let number = 0; ...; ...) {
        // Can use number here
}
// Cannot use number here
```

- Executed once, just before the loop is entered
- Usually used to declare a counter variable (indexer)

<div class="balloon" style="top:17%; left:13%; width:175px; height:20px; opacity: 0.3"></div>



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Conditional Expression

```javascript
for (let number = 0; number < 10; ...) {    
    // Can use "number" here
}
// Cannot use "number" here
```

- Evaluated before each iteration of the loop
  - If `true`, the loop body is executed
  - If `false`, the loop body is skipped
- Used as a `loop condition`

<div class="balloon" style="top:17%; left:36%; width:135px; height:20px; opacity: 0.3"></div>




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Update Expression

```javascript
for (let number = 0; number < 10; number++) {
       // Can use "number" here
}
// Cannot use "number" here
```

- Executed at each iteration `after` the body of the loop is finished
- Usually used to update the counter


<div class="balloon" style="top:17%; left:54%; width:100px; height:20px; opacity: 0.3"></div>


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # for Loop -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic16.png" style="top:41.65%; left:28%; width:45%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Simple for Loop – _Example_
- A simple `for`-loop to print the numbers 0…9:

```javascript
for (let number = 0; number < 10; number++) {
    console.log(number + " ");
}
```

- A simple for-loop to calculate n!:

```javascript
let factorial = 1;
for (let i = 1; i <= n; i++) {
    factorial *= i;
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Complex for Loop – _Example_
- Complex `for`-loops could have several counter variables:

```javascript
for (let i = 1, sum = 1; i <= 128; i = i*2, sum += i) {
   console.log(`i=${0}, sum=${1}`);
}
```
- Result:

```javascript
i = 1, sum = 1
i = 2, sum = 3
i = 4, sum = 7
i = 8, sum = 15
...
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # For Loops -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/ForLoops)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic17.png" style="top:55%; left:35%; width:30%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# N^M – _Example_
- Calculating `n` to power `m` (denoted as `n^m`):

```javascript
let n = 1;
let m = 10;
let result = 1;

for (let i = 0; i < m; i++) {
    result *= n;
}

console.log(`${n}*${m} = ${result}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Calculating N^M -->
## [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using a complex for loop – _Example_
- Drawing diagonal lines on the console

```javascript
for (let left = 1, right = 20 ; right > 0; right -= 2, left += 1) {
    let displacementRight =
			Array.from({ length: right }).join(' ')
    let displacementLeft =
			Array.from({ length: left }).join(' ')

    console.log(displacementLeft + '*' + displacementRight + '*');
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Diagonal Lines -->
## [Demo]()


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Using continue Operator
- `continue` operator ends the iteration of the inner-most loop
- _Example_: sum all odd numbers in [1, n] that are not divisors of 7:

```javascript
let n = 9;
let sum = 0;
for (let i = 1; i <= n; i += 2) {
    if (i % 7 == 0) {
        continue;
    }

    sum += i;
}
console.log(`sum = ${sum}`);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Using continue Operator -->
## [Demo]()
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic19.png" style="top:55%; left:35%; width:30%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # for-in Loop
## iterates over the properties of an object and over the elements of an array-->

<!-- attr: { id:'forin', class:'', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="forin"></a>For-in Loops
- The typical `for-in` loop syntax is:

```javascript
for (const property in object) {
    statements;
}
```

- Iterates over all properties of an object
  - The `property` is the loop variable that takes sequentially all object properties one by one
  - The `object` can be object, array or other group of elements of the same type



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# for-in Loop – _Example_
- _Example_ of `for-in` loop:

```javascript
const workDays = {
	Monday: '1',
	Tuesday: '2',
	Wednesday: '3',
	Thursday: '4',
	Friday: '5',
}

for (const day in workDays) {
    console.log(day);
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# for-in Loop – _Example_
- The above loop iterates over the properties of the `workDays` object.
  - The variable `day` takes each property name
- In the `foreach` loop we cannot set the value of the current item
 - it is **read-only**



 <!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
 # for-in Loop – _Example_
 - _Example_ of `for-in` loop:  


 ```javascript
 const arr = [1, 2, 3, 4, 5];

 for (const index in arr) {
     console.log(arr[index]);
 }

 // Outputs
 // 1
 // 2
 // 3
 // 4
 // 5
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# for-in Loop – _Example_
- The above loop iterates over the elements of the `array`.
 - Can be used only on arrays, or array-like objects
	 - i.e. the arguments object



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # for-in Loop -->
## [Demo]()



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # for-of Loop
## iteretion over a collection of elements-->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# for-of Loop – _Example_
- _Example_ of `for-of` loop:  


```javascript
const workDays = [
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday"];

for (const day of workDays) {
    console.log(day);
}
```

- The `for-of` loop is part of the **ECMAScript 6** standard
 - Supported in all modern browsers



 <!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
 <!-- # for-of Loop -->
 ## [Demo]()



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Nested Loops
## Using loops inside a loop -->  

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic22.png" style="top:55%; left:35%; width:30%; z-index:-1; border:2px solid white; border-radius: 15px;" /> -->




<!-- attr: { id:'nestedloops', class:'', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="nestedloops"></a>What Is Nested Loop?
- A composition of loops is called a `nested loop`
  - A loop inside another loop
- _Example_:

```javascript
for (initialization; condition; update) {
    for (initialization; condition; update) {			
        statements;
    }
    …
}
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Nested Loops
## _Examples_ -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic23.png" style="top:55%; left:38%; width:25%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size:0.8em;' } -->
# Triangle – _Example_
- Print the following triangle:

     1

     1 2

     1 2 3 ... n



```javascript
const n = 10;

for (let row = 1; row <= n; row += 1) {
    var line: string = '';

    for (let column = 1; column <= row; column += 1) {
        line += `${column} `;
    }

    console.log(line);
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Triangle -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/Triangle)


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size:0.8em;' } -->
# Primes[N, M] – _Example_
- Print all prime numbers in the interval [n, m]:  


```javascript
const n = 2;
const m = 21;
for (let number = n; number <= m; number += 1) {
    let isPrime = true;
    let divider = 2;
    let maxDivider = Math.sqrt(number);

    while (divider <= maxDivider) {
        if (number % divider == 0) {
            isPrime = false;
            break;
        }

        divider++;
    }

    if (isPrime) {
        console.log(`${number}`);
    }
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Primes in Range [n, m] -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/Primes)


<!-- attr: { id:'breakcontinue', class:'', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="breakcontinue"></a>TypeScript Jump Statements
- Jump statements are:
  - `break` and `continue`
- How `continue` works?
  - In `while` and `do-while` loops jumps to the condition expression
  - In `for` loops jumps to the update expression
- To exit an inner loop use `break`


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.8em' } -->
# _TypeScript_ <br/>Jump Statements – _Example_

```javascript
let outerCounter = 0;

for (let outer = 0; outer < 10; outer++)
{
    for (let inner = 0; inner < 10; inner++)
    {
        if (inner % 3 == 0) {
            console.log('continue');
            continue;
        }

        if (outer + inner >= 7) {
            console.log('break');
            break;
        }
    }

    outerCounter++;
}

```


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Loops – More _Examples_ -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic26.png" style="top:45%; left:33%; width:30%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Nested Loops – _Examples_
- Print all four digit numbers in format `ABCD` such that `A`+`B` = `C`+`D` (known as happy numbers)

```javascript
for (let a = 1; a <= 9; a++)
    for (let b = 0; b <= 9; b++)
        for (let c = 0; c <= 9; c++)
            for (let d = 0; d <= 9; d++)
                if (a + b == c + d)
                    console.log(`${a}${b}${c}${d}`);

```

<div class="fragment balloon" style="top:35%; left:66.12%;">Can you improve this algorithm to use 3 loops only?</div>


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Happy Numbers -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/HappyNumbers)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic27.png" style="top:55%; left:38%; width:23%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Nested Loops – _Examples_
- Print all combinations from TOTO 6/49


```javascript
let i1, i2, i3, i4, i5, i6;
for (i1 = 1; i1 <= 44; i1++)
    for (i2 = i1 + 1; i2 <= 45; i2++)
        for (i3 = i2 + 1; i3 <= 46; i3++)
            for (i4 = i3 + 1; i4 <= 47; i4++)
                for (i5 = i4 + 1; i5 <= 48; i5++)
                    for (i6 = i5 + 1; i6 <= 49; i6++)
                        console.log(`${i1} ${i2} ${i3} ${i4} ${i5} ${i6}`);
```

<div class="fragment balloon" style="top:21.52%; left:67.00%">Warning: the execution of this code could take too long time.</div>


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # TOTO 6/49 -->
## [Demo](https://github.com/TelerikAcademy/CSharp-Part-1/tree/master/Topics/06.%20Loops/demos/Toto)
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic28.png" style="top:55%; left:33%; width:35%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Summary
- TypeScript supports five types of loops:
  - `while`
  - `do-while`
  - `for` loops
  - `for-in` loops
  - `for-of` loops
- Nested loops can be used to implement more complex logic
- The operators `continue` & `break` can control the loop execution

<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic29.png" style="top:21%; left:66%; width:28.21%; z-index:-1; border: 1px solid white; border-radius: 15px;" /> -->


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Loops
## Any questions? -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- Fundamentals of TypeScript Programming Track of Courses
    - [typescript.fundamentals](http://telerikacademy.com/Courses/typescript-fundamentals)
  - Telerik School Academy
    - [academy.telerik.com](academy.telerik.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Academy Learning System
    - [telerikacademy.com](https://telerikacademy.com)


<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic32.png" style="top:35%; left:75%; width:10.85%; z-index:-1; border-radius: 15px; border:1px solid white;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic30.png" style="top:51%; left:75%; width:16.97%; z-index:-1; border-radius: 15px; border:1px solid white;" /> -->
<!-- <img class="slide-image" showInPresentation="true"  src="imgs/pic31.png" style="top:78%; left:75%; width:25%; z-index:-1; border-radius: 15px; border:1px solid white;" /> -->
