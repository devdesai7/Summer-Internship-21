const express = require('express');
//const bodyParser = require('body-parser');

const mongoConnect = require('./util/database').mongoConnect;

const controllers = require('./controllers/addUser');
const controllers1 = require('./controllers/Login');

const session = require('express-session');
const app = express();

app.set('view engine', 'ejs');

//app.use(bodyParser.urlencoded({ extended: false }));

//Both Below are alternative for above urlencoded 2nd one is for urlencoded and 1st one is for json 
//app.use(express.json()); //Used to parse JSON bodies
app.use(express.urlencoded()); //Parse URL-encoded bodies
app.use(session({secret:'my secret',resave:false, saveUninitialized:false}));


app.get('/signup',controllers1.getSignUp);
app.post('/signup',controllers1.postSignUp);


app.get('/Login',controllers.login);
app.post('/Login',controllers.loginbutton);


app.get('/Message',controllers.showData)

app.get('/addData',controllers.getUser);

app.post('/addData',controllers.addUser);


mongoConnect(() => {
    app.listen(3000);
  });
  