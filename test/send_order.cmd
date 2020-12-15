@echo off

curl -f -i -X POST http://localhost:5000/orders -H "Content-Type: application/json" -d @order.json 
