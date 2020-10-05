import React, { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.scss";
import axios from "axios";
import { War } from "./models/War";
import env from "@beam-australia/react-env";

const api = axios.create({
  baseURL: env("API_URL"),
});

function App() {
  const defaultValue:Array<War> = []; 
  const [wars, setWars] = useState<Array<War>>(defaultValue);

  useEffect(() => {
  api.get<Array<War>>("fight").then((response) => {
    console.log(response.data);
    setWars(response.data);
  });
 },[]);

  return (
    <div className="App">
      <header className="App-header">
      <div>Current environment: <b>{env("NODE_ENV")}</b>.</div>
      <div> REACT_APP_API_URL SIN REACT_aPP: <b>{env("API_URL")}</b>.</div>
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <div>
          {wars.map((war, index) => (
            <li key={index}>{war.showResult}</li>
            //    <img src={character.thumbnail} alt="Italian Trulli"></img>
          ))}
        </div>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
