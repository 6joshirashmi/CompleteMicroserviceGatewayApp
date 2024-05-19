whole app will work on docker
Folder "serviceCommunication" - we'll user KAFKA

implement 1st Design pattern in Microservice - Gateway pattern
package - Ocelot API Gateway

need to configure RabbitMQ server, KAFKA server for microservices communicaition
 2 topics -
    a. observable pattern - all messeging services 
    b. record/class - pattern matching in C#


    http://localhost:5002/api/Customer/GetProductList'
    http://localhost:5002/api/Customer/SaveProduct


http://localhost:5001/api/Product/GetProductList
http://localhost:5001/api/Product/SaveProduct

19/05/2024

containerize these 2 api and gateway on docker

aggregation model
association model
composition model ( docker compose) facade pattern (control panel is a best example)
composition model of all services 
