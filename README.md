# 🔁 Loop Demos

> Reference demos for capturing and observing LLM traffic with **Loop**.

This repository illustrates different traffic capture approaches across multiple programming languages and runtimes. The demos are designed to be **minimal**, **readable**, and **easy to adapt**.

**Who is this for?**
- Developers evaluating Loop
- Experimentation and learning
- Copy–paste starting points for real projects

---

## 🧐 What is Loop?

[Loop](https://github.com/lensapp) is an observability and evaluation platform for LLM-powered applications.

| Capability | Description |
|------------|-------------|
| 📡 Capture | Intercept and record LLM traffic |
| 🔍 Understand | Analyze prompts and responses |
| ✅ Evaluate | Measure quality and correctness |
| 🔄 Iterate | Improve AI behavior over time |

> **Note:** This repository focuses on **traffic capture** — the first step in the Loop workflow.

---

## 🎯 Demo Approaches

### Proxy-based capture

| Benefit | Description |
|---------|-------------|
| 🔌 Non-invasive | Intercept traffic without modifying application code |
| 🚫 No code changes | Useful when source modifications are not possible |
| 🏢 Centralized | Single capture point for multiple applications |

### OpenTelemetry-based capture

| Benefit | Description |
|---------|-------------|
| 📊 Rich context | Structured traces with full context |
| 🛠️ SDK integration | Native instrumentation via OpenTelemetry |
| 🎛️ Full control | Best when you own the application code |

---

## 📁 Repository Structure

| Path | Description |
|------|-------------|
| `demos/dotnet/proxy/` | .NET proxy demo |
| `demos/node/proxy/` | Node.js proxy demo |
| `demos/python/proxy/` | Python proxy demo |

---

## ⚙️ Demos included

### Proxy demos (working)
- .NET: `demos/dotnet/proxy`
- Node.js: `demos/node/proxy`
- Python: `demos/python/proxy`
---

## 🚀 Quick start

1) Start Loop (Desktop + Server) and ensure the Loop Proxy endpoint is available.

2) Pick a demo and follow its README:
- `demos/dotnet/proxy/README.md`
- `demos/node/proxy/README.md`
- `demos/python/proxy/README.md`

3) Run the demo and verify:
- you see the response in the terminal
- you see the request/response captured in Loop

---

## 🛠️ Configuration (common)

Most demos use environment variables:

- `OPENAI_API_KEY`  
  API key for the target LLM provider

- `LOOP_PROXY_BASE_URL`  
  Base URL of the Loop Proxy  
  Default used by demos: `http://localhost:31300/openai`

- `OPENAI_MODEL`  
  Model name  
  Default used by demos: `gpt-4o`

Notes:
- Never commit API keys or `.env` files to Git.
- If you get `401 Unauthorized`, verify the API key and proxy configuration.

---

## 📦 Demos Included

| Language | Proxy | OpenTelemetry |
|----------|-------|---------------|
| .NET | ✅ [`demos/dotnet/proxy`](demos/dotnet/proxy) | 🚧 Planned |
| Node.js | ✅ [`demos/node/proxy`](demos/node/proxy) | 🚧 Planned |
| Python | ✅ [`demos/python/proxy`](demos/python/proxy) | 🚧 Planned |

---

## 🚀 Quick Start

1. **Start Loop**  
   Launch Loop (Desktop + Server) and ensure the Loop Proxy endpoint is available.

2. **Pick a demo** and follow its README:
   - [.NET Proxy Demo](demos/dotnet/proxy/README.md)
   - [Node.js Proxy Demo](demos/node/proxy/README.md)
   - [Python Proxy Demo](demos/python/proxy/README.md)

3. **Verify capture:**
   - ✅ Response appears in the terminal
   - ✅ Request/response is captured in Loop

---

## ⚙️ Configuration

All demos use these environment variables:

| Variable | Description | Default |
|----------|-------------|---------|
| `OPENAI_API_KEY` | API key for the LLM provider | *required* |
| `LOOP_PROXY_BASE_URL` | Base URL of the Loop Proxy | `http://localhost:31300/openai` |
| `OPENAI_MODEL` | Model name to use | `gpt-4o` |

> ⚠️ **Security:** Never commit API keys or `.env` files to Git.

**Troubleshooting:**
- `401 Unauthorized` → Verify your API key and proxy configuration
