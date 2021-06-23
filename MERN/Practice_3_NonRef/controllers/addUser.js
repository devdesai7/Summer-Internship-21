const User = require("../models/user");

exports.getUser=(req,res,next)=>{
    
res.render('enterData');
};

exports.addUser = (req,res,next)=>{

const name = req.body.name;
const email = req.body.email;

const user = new User(name,email);
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
