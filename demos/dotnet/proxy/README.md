# 🟣 .NET Proxy Demo

> Capture LLM traffic from a .NET application using **Loop Proxy**.

This demo shows how to route OpenAI requests through Loop Proxy for full observability. It's intentionally minimal — designed for learning and experimentation, not production use.

---

## 🎯 What This Demo Does

1. Sends chat requests from a .NET application
2. Routes all requests through Loop Proxy
3. Proxy forwards requests to OpenAI
4. **Loop captures everything** — requests, responses, latency, tokens

---

## 📋 Requirements

| Requirement | Details |
|-------------|---------|
| .NET SDK | 8.0 or newer |
| Loop Proxy | Running locally or remotely |
| Network | Access to LLM provider |

---

## 📁 Project Structure

| File | Description |
|------|-------------|
| `src/Loop.Demos.DotNet.ProxyClient/Program.cs` | Demo application entry point |
| `src/Loop.Demos.DotNet.ProxyClient/*.csproj` | Project file with dependencies |
| `README.md` | This file |

---

## ⚙️ Configuration

### Required

| Variable | Description |
|----------|-------------|
| `OPENAI_API_KEY` | API key for OpenAI |

### Optional

| Variable | Default | Description |
|----------|---------|-------------|
| `LOOP_PROXY_BASE_URL` | `http://localhost:31300/openai` | Loop Proxy endpoint |
| `OPENAI_MODEL` | `gpt-4o` | Model to use |

---

## 🚀 Quick Start

### 1️⃣ Restore dependencies

```bash
dotnet restore
```

### 2️⃣ Set environment variables

<details>
<summary><b>Windows PowerShell</b></summary>

```powershell
$env:OPENAI_API_KEY="sk-..."
$env:LOOP_PROXY_BASE_URL="http://localhost:31300/openai"
$env:OPENAI_MODEL="gpt-4o"
```

</details>

<details>
<summary><b>macOS / Linux</b></summary>

```bash
export OPENAI_API_KEY=sk-...
export LOOP_PROXY_BASE_URL=http://localhost:31300/openai
export OPENAI_MODEL=gpt-4o
```

</details>

### 3️⃣ Run the demo

```bash
dotnet run --project src/Loop.Demos.DotNet.ProxyClient
```

You can now type questions into the terminal.  
Responses will be printed and captured by Loop.  
Type `exit` to quit.

### 4️⃣ Verify it works

- ✅ Type a question in the terminal
- ✅ See the response printed
- ✅ Check Loop Dashboard for captured traffic
- Type `exit` to quit

---

## 💡 Notes

> ⚠️ **Security:** Never commit API keys or `.env` files to Git.

- Uses the official `Azure.AI.OpenAI` or `OpenAI` NuGet package
- No OpenTelemetry instrumentation (see `../otel` for that approach)
- No production-ready error handling

---

## 🔗 Related Demos

| Language | Path |
|----------|------|
| Node.js | [`demos/node/proxy`](../../node/proxy) |
| Python | [`demos/python/proxy`](../../python/proxy) |

---

## 🆘 Troubleshooting

| Problem | Solution |
|---------|----------|
| `401 Unauthorized` | Check your `OPENAI_API_KEY` |
| `Connection refused` | Ensure Loop Proxy is running |
| `Could not find project` | Run from the `demos/dotnet/proxy` directory |
| `SDK not found` | Install [.NET 8.0+](https://dotnet.microsoft.com/download) |
