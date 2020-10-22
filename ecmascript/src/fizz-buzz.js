'use strict'

const _ = require('lodash');

const fizzBuzz = function() {
    console.log('Starting Fizz Buzz');
    for (const idx of _.range(1, 100)) {
        if (idx % 15 === 0) {
            console.log('FizzBuzz');
        } else if (idx % 3 === 0) {
            console.log('Fizz');
        } else if (idx % 5 === 0) {
            console.log('Buzz');
        } else {
            console.log(idx);
        }
    }
}

module.exports = fizzBuzz;