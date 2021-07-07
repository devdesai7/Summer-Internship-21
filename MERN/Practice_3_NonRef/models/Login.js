class Users{
    constructor(username,email,pass)
    {
        this.name = username;
        this.email = email;
        this.pass = pass;
    }

    save()
    {
        const db = getDb();
            return db.collection('Singinusers').insertOne(this)
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
            return db.collection('Singinusers')
          .find().toArray();
    }

}
module.exports = Users;