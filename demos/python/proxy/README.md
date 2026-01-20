# Python Proxy Demo (Loop)

This demo shows how a Python application sends LLM requests through a Loop Proxy so that all traffic is captured and visible in Loop.

The demo is intentionally minimal and meant for learning and experimentation.  
It is not intended for production use.

## What this demo does

- Sends chat requests from a Python application
- Routes all requests through a Loop Proxy
- The proxy forwards requests to the LLM provider
- Loop captures requests and responses

**High-level flow**

```
Python application → Loop Proxy → LLM provider
```

All captured traffic is visible in Loop.

## Requirements

- Python version 3.8 or newer
- Loop Proxy running locally or remotely
- Network access to the LLM provider

## Project structure

```
proxy
├── README.md
├── main.py
└── requirements.txt
```

## Configuration

This demo uses environment variables.

### Required

**OPENAI_API_KEY**  
API key for the LLM provider.

### Optional

**LOOP_PROXY_BASE_URL**  
Base URL of the Loop Proxy.  
Default value: `http://localhost:31300/openai`

**OPENAI_MODEL**  
LLM model name.  
Default value: `gpt-4o`

## Running the demo

### Step 1: Install dependencies (run once)

```bash
pip install -r requirements.txt
```

### Step 2: Set environment variables

**Windows PowerShell**

```powershell
$env:OPENAI_API_KEY="sk-..."
$env:LOOP_PROXY_BASE_URL="http://localhost:31300/openai"
$env:OPENAI_MODEL="gpt-4o"
```

**macOS or Linux**

```bash
export OPENAI_API_KEY=sk-...
export LOOP_PROXY_BASE_URL=http://localhost:31300/openai
export OPENAI_MODEL=gpt-4o
```

### Step 3: Run the demo

```bash
python main.py
```

You can now type questions into the terminal.  
Responses will be printed and captured by Loop.  
Type `exit` to quit.

## Notes

- This demo uses plain HTTP requests
- No OpenTelemetry instrumentation
- No SDK-specific abstractions
- API keys must never be committed to Git

## Related demos

- `demos/dotnet/proxy`
- `demos/node/proxy`
