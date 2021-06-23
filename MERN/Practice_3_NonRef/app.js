const express = require('express');
//const bodyParser = require('body-parser');

const mongoConnect = require('./util/database').mongoConnect;

const controllers = require('./controllers/addUser');

const app = express();

app.set('view engine', 'ejs');

//app.use(bodyParser.urlencoded({ extended: false }));

//Both Below are alternative for above urlencoded 2nd one is for urlencoded and 1st one is for json 
//app.use(express.json()); //Used to parse JSON bodies
app.use(express.urlencoded()); //Parse URL-encoded bodies

app.get('/Message',controllers.showData)

app.get('/addData',controllers.getUser);

app.post('/addData',controllers.addUser);


mongoConnect(() => {
    app.listen(3000);
  });
  