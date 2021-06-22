const express = require('express');

const app = express();


app.use('/a', (req, res, next) => {
    console.log("in A");
    res.send("<h1>IN A </h1>");

});
app.use('/b', (req, res, next) => {
    console.log("in B");
    res.send("<h1>IN B </h1>");
});

app.use('/', (req, res, next) => {
    console.log("in middleware");
    res.send("<h1>IN MID </h1>");
});

app.listen(1000);