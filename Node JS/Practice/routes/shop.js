const express = require('Express');
const router = express.Router();

const path =require('path');
const { cpuUsage } = require('process');
const adminData = require('./admin');


router.get('/',(req,res,next)=>{
    //console.log("In the another middleware ");
    //For HTML
   console.log(adminData.product);
//res.sendFile(path.join(__dirname,'../','views','shop.html'));
    //For Template Engine
    res.render('shop',{prods:adminData.product,docTitle:"Shop",hasProducts : adminData.product.length>0});
}); //Seems like a defualt condition

module.exports = router;