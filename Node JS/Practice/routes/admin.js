const path = require('path');

const express =require('express');

const  rootDir = require('../util/path');
const router = express.Router();

const product =[];
router.get('/add-product',(req,res,next)=>{
    console.log("In the another  ");
//    res.sendFile(path.join(rootDir,'views','add-product.html'));
        res.render("add-product",{docTitle:"ADD PROD"});

});

router.post('/add-product',(req,res,next)=>{
    //console.log(req.body);
    product.push({title:req.body.title});
    
    res.redirect('/');

});

exports.routes = router; // exports router and the way now it its accesed in app.js is bit different than earlier
//here we are exporting more than one objects

// earlier we were all in one , now it's been differentiated
exports.product= product;