const express = require('express');
const bodyParser = require('body-parser');
const path =require('path');


const app =  express();
//For HandleBar
//const  expressHbs = require('express-handlebars');
//app.engine('hbs',expressHbs());
//app.set('view engine','hbs'); // hbs here will be the extension and it can be any name

//For Pug
// "set" allows to set value globally
//app.set('view engine','pug');
//if you store your templates in different folder
//.set('view','views'); 

//For EJS
app.set('view engine','ejs');


const adminRoutes = require('./routes/admin');
const shopRoute = require('./routes/shop');


app.use(bodyParser.urlencoded({extended:false}));
app.use(express.static(path.join(__dirname,'public')));
//above line will directly forward it to the system

/*app.use((req,res,next)=>{
    console.log("In the middleware ");
    next();
});// will be used for every incoming request
*/

app.use('/',(req,res,next)=>{
    console.log("Always ");
    next();
});
//adminRoutes means all the exports 
app.use('/admin',adminRoutes.routes); // Will use automatically consider our  routes from admin JS file
app.use(shopRoute);

app.use((req,res,next)=>
{
res.status(404).send("<h1>404 Page Not Found </h1>")
});
/*
const server = http.createServer(app);

server.listen(3000);
*/
app.listen(3000);//Creates the server and listens to it 