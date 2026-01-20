import fetch from "node-fetch";
import readline from "node:readline";

const OPENAI_API_KEY = process.env.OPENAI_API_KEY;
const LOOP_PROXY_BASE_URL = process.env.LOOP_PROXY_BASE_URL || "http://localhost:31300/openai";
const MODEL = process.env.OPENAI_MODEL || "gpt-4o";

if (!OPENAI_API_KEY) {
  console.error("Missing OPENAI_API_KEY environment variable");
  process.exit(1);
}

const endpoint = `${LOOP_PROXY_BASE_URL}/v1/chat/completions`;

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

console.log("Ask anything. Type 'exit' to quit.");

function ask() {
  rl.question("> ", async (input) => {
    if (!input) {
      ask();
      return;
    }

    if (input.toLowerCase() === "exit") {
      rl.close();
      return;
    }

    try {
      const response = await fetch(endpoint, {
        method: "POST",
        headers: {
          "Authorization": `Bearer ${OPENAI_API_KEY}`,
          "Content-Type": "application/json"
        },
        body: JSON.stringify({
          model: MODEL,
          messages: [
            { role: "user", content: input }
          ],
          temperature: 0.2
        })
      });

      if (!response.ok) {
        const text = await response.text();
        throw new Error(`HTTP ${response.status}: ${text}`);
      }

      const data = await response.json();
      const answer = data.choices[0].message.content;

      console.log();
      console.log(answer);
      console.log();

    } catch (err) {
      console.error("Error:", err.message);
    }

    ask();
  });
}

ask();
