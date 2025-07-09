# Tacklebox

**Tacklebox** (WIP) is a self-hosted webhook tester built with **.NET 9 Minimal API** and **LiteDB** as embedded NoSQL storage. It allows you to register dynamic endpoints, receive webhook requests (POST, GET, PUT, DELETE), and store logs locally.

### Plans

- Dynamically register endpoints via API
- Logs payloads, headers, method, and timestamp
- Supports secrets, headers, and validation rules
- Uses **LiteDB** (no external database required, but can be configured) 
- **ngrok-compatible** for exposing local endpoints to the internet