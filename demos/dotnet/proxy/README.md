# .NET Proxy Demo (Loop)

This demo shows how to capture LLM traffic using a **.NET-based proxy** and send it to Loop for observability and evaluation.

The demo is intentionally minimal and designed for:
- learning
- experimentation
- copy–paste usage

It is **not intended for production use**.

---

## What this demo demonstrates

- A simple .NET proxy that intercepts outbound LLM HTTP requests
- Transparent forwarding of requests to the actual LLM provider
- Capturing request / response metadata and payloads
- Sending captured data to a local Loop Server

---

## Architecture (high level)

