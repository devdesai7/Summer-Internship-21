const session = require("express-session");
const User = require("../models/user");

exports.getUser=(req,res,next)=>{
    const isLogged = req.get('Cookie')
.split(';')[0].trim().split('=')[1] ;
res.render('enterData',{isLoggedin:isLogged});
};

exports.addUser = (req,res,next)=>{

const name = req.body.name;
const email = req.body.email;

const user = new User(name,email,pass);
user.save()
.then(result=>{

    console.log("User Entered");
    res.redirect('Message');
})
.catch(err=>{
console.log(err);
});

};


exports.showData = (req,res,next)=>{
//req.session.isLoggedin
    User.fetchAll()
    .then(products => {
      res.render('Message', {
        prods: products,
       });
    })
    .catch(err => {
      console.log(err);
    });

};


exports.login= (req,res,next) =>{
res.render('log');
};
exports.loginbutton= (req,res,next) =>{
    //Cookie
    //res.setHeader('Set-Cookie','loggedIn=true');
    //Session
    req.session.isLoggedin =true;
    req.session.save();
    
    res.redirect('addData');
    };
    
