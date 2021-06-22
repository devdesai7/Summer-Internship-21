const mongodb = require('mongodb');
const MongoClient = mongodb.MongoClient;

let _db;

const mongoConnect = (callback)=>{
    MongoClient.connect("mongodb+srv://root:dev@123@cluster0.vmxfq.mongodb.net/myFirstDatabase?retryWrites=true&w=majority")
    .then(client=>{
    console.log("Connected");
        _db = client.db();

    callback();
    })
    .catch(err=>
        {
            console.log(err);
            throw err;
    });
    
    
}

const getDB=() =>{
if(_db){
    return _db; 
}
throw "no DB Found";
};

exports.mongoConnect = mongoConnect;
exports.getDB = getDB;