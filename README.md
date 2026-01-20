# Loop Demos

This repository contains **reference demos** for capturing and observing LLM traffic with **Loop**.

The demos illustrate different traffic capture approaches across multiple programming languages and runtimes.  
They are designed to be **minimal, readable, and easy to adapt**.

This repository is intended for:
- developers evaluating Loop
- experimentation and learning
- copy–paste starting points for real projects

---

## What is Loop?

Loop is an observability and evaluation platform for LLM-powered applications.

It helps you:
- capture LLM traffic
- understand prompts and responses
- evaluate quality and correctness
- iterate and improve AI behavior

This repository focuses specifically on **traffic capture**, which is the first step in the Loop workflow.

---

## Demo approaches

The demos are grouped by **capture strategy**:

### Proxy-based capture
- Intercept LLM traffic without modifying application code
- Useful when source code changes are not possible
- Centralized capture for multiple applications

### OpenTelemetry-based capture
- Instrument applications using OpenTelemetry SDKs
- Rich context and structured traces
- Best fit when you control the application code

---

## Repository structure

