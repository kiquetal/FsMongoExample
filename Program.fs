open System
open System.Threading
open MongoDB.Driver
open MongoDB.Bson

[<EntryPoint>]
let main argv =
    // Connection string with credentials from docker-compose.yml
    let connectionString = "mongodb://admin:password@localhost:27017"
    
    try
        let client = new MongoClient(connectionString)
        let database = client.GetDatabase("test_db")
        
        // Simple command to verify connection (ping)
        let command = BsonDocument("ping", BsonInt32(1))
        let _ = database.RunCommand<BsonDocument>(command)
        
        printfn "Successfully connected to MongoDB!"
        
        // List databases to be sure
        printfn "Databases on server:"
        use cursor = client.ListDatabases(CancellationToken.None)
        let dbList = cursor.ToList()
        for db in dbList do
            printfn " - %s" (db.GetElement("name").Value.ToString())

    with
    | ex -> printfn "Error connecting to MongoDB: %s" ex.Message

    0