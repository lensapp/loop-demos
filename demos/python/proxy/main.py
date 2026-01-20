import os
import requests
import json

# Configuration via environment variables
OPENAI_API_KEY = os.getenv("OPENAI_API_KEY")
LOOP_PROXY_BASE_URL = os.getenv(
    "LOOP_PROXY_BASE_URL",
    "http://localhost:31300/openai"
)
MODEL = os.getenv("OPENAI_MODEL", "gpt-4o")

# Check required environment variables
if not OPENAI_API_KEY:
    print("ERROR: OPENAI_API_KEY environment variable is not set.")
    print("Set it with: set OPENAI_API_KEY=your-api-key")
    exit(1)

headers = {
    "Authorization": f"Bearer {OPENAI_API_KEY}",
    "Content-Type": "application/json"
}   

endpoint = f"{LOOP_PROXY_BASE_URL}/v1/chat/completions"

print("Ask anything. Type 'exit' to quit.")

while True:
    user_input = input("> ").strip()

    if not user_input:
        continue

    if user_input.lower() == "exit":
        break

    payload = {
        "model": MODEL,
        "messages": [
            {"role": "user", "content": user_input}
        ],
        "temperature": 0.2
    }

    try:
        response = requests.post(
            endpoint,
            headers=headers,
            data=json.dumps(payload),
            timeout=60
        )

        response.raise_for_status()
        data = response.json()

        answer = data["choices"][0]["message"]["content"]
        print()
        print(answer)
        print()

    except Exception as e:
        print(f"Error: {e}")
