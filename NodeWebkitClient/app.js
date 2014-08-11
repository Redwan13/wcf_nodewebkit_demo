var Client = require('node-rest-client').Client;

// uncomment to enable webkit developers console
//require('nw.gui').Window.get().showDevTools(); 

var getHelloWorld = function(){
    client = new Client();
    var result = "";
    client.get("http://localhost:9000/helloworld", function(data, response){
        document.write(data);
        });
       
}