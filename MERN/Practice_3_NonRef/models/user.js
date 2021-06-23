const getDb = require('../util/database').getDb;
class User{
    constructor(username,email)
    {
        this.name = username;
        this.email = email;
    }

    save()
    {
        const db = getDb();
            return db.collection('users').insertOne(this)
            .then(result=>{
              //  console.log(result);
            })
            .catch(err=>{
                console.log(err);
            })
    }
    static fetchAll()
    {
        const db = getDb();
            return db.collection('users')
          .find().toArray();
    }

}
module.exports = User;