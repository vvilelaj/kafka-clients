# Kafka Clients
Personal repo for testing kafka clients.

## Kafka Producer
It writes string messages to "first_topic" topic.
### Commands
```
cd kafka-producer
dotnet restore
dotnet build
dotnet run
```
### output
```
Producing record: alice {"count":0}
Producing record: alice {"count":1}
Producing record: alice {"count":2}
Producing record: alice {"count":3}
Producing record: alice {"count":4}
Producing record: alice {"count":5}
Producing record: alice {"count":6}
Producing record: alice {"count":7}
Producing record: alice {"count":8}
Producing record: alice {"count":9}
Produced message to: first_topic [[0]] @0
Produced message to: first_topic [[0]] @1
Produced message to: first_topic [[0]] @2
Produced message to: first_topic [[0]] @3
Produced message to: first_topic [[0]] @4
Produced message to: first_topic [[0]] @5
Produced message to: first_topic [[0]] @6
Produced message to: first_topic [[0]] @7
Produced message to: first_topic [[0]] @8
Produced message to: first_topic [[0]] @9
10 messages were produced to topic first_topic

```

## Kafka Consumer
It reads string messages to "first_topic" topic.

### Commands
```
cd kafka-producer
dotnet restore
dotnet build
dotnet run
```

### output
```
Consumed record with key alice and value {"count":0}, and updated total count to 0
Consumed record with key alice and value {"count":1}, and updated total count to 1
Consumed record with key alice and value {"count":2}, and updated total count to 3
Consumed record with key alice and value {"count":3}, and updated total count to 6
Consumed record with key alice and value {"count":4}, and updated total count to 10
Consumed record with key alice and value {"count":5}, and updated total count to 15
Consumed record with key alice and value {"count":6}, and updated total count to 21
Consumed record with key alice and value {"count":7}, and updated total count to 28
Consumed record with key alice and value {"count":8}, and updated total count to 36
Consumed record with key alice and value {"count":9}, and updated total count to 45

```