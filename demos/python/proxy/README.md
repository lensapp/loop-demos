# Python Proxy Demo (Loop)

This demo shows how to capture LLM traffic using a **Python-based client** that routes all OpenAI-compatible requests through a **Loop Proxy**.

The demo is intentionally minimal and designed for:
- learning
- experimentation
- copy–paste usage

It is **not intended for production use**.

---

## What this demo demonstrates

- A simple Python application that sends Chat Completions requests
- All LLM traffic is routed through a Loop Proxy
- The proxy forwards requests to the actual LLM provider
- Requests and responses are captured by Loop for observability and evaluation

---

## Architecture (high level)

