const User = require("../models/Login");


exports.getSignUp=(req,res,next)=>{

    res.render('signup');
};

exports.postSignUp=(req,res,next)=>{

    res.render('');
};
