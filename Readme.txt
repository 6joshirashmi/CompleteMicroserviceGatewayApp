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

finaly all the services are configured with api services so that end user can access the service 
from apigetway which provide base address communicate to the all the services.

docker-compose /kube ctl is a tool to configure all the service yaml file

ConnectionFactory class 

customerapi...docker...sql
productapi...docker...sql

for messaging between multiple services we have taken services library..




