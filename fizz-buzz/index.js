
const fizzBuzz = (n) => {
    return (((n % 3 === 0) ? "Fizz" : "") + ((n % 5 === 0) ? "Buzz" : "")) || n;

}

for (let i = 1; i <= 100; i++) {
    console.log(fizzBuzz(i));
}