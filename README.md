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
Produced message to: first_topic [[0]] @4
Produced message to: first_topic [[0]] @5
Produced message to: first_topic [[0]] @6
Produced message to: first_topic [[0]] @7
Produced message to: first_topic [[0]] @8
Produced message to: first_topic [[0]] @9
Produced message to: first_topic [[0]] @10
Produced message to: first_topic [[0]] @11
Produced message to: first_topic [[0]] @12
Produced message to: first_topic [[0]] @13
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

```