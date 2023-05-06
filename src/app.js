// all code is using just-js with modules at ../modules
// new static server


const config = require("dummy.js");
const { message, json, extra } = config;

just.print(config); // undefined
const http = require("@http");
const { createServer, responses } = http;


const stringify = require("@stringify");
const { sjs, attr } = stringify;

const port = 4000;
const sJSON = sjs({ message: attr("string") });
// const message = "Hello, World!";
// const json = { message };
// const extra = { id: 0, message: "Additional fortune added at request time." };


const server = createServer()
  .get("/plaintext", (res) => res.text(message))
  // ReferenceError: sJSON is not defined 

  .get("/json", (res) => res.utf8(sJSON(json), responses.json))
  .listen("0.0.0.0", port);

just.print("Serving on http://localhost:" + port + "\n");