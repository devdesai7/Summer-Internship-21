import React from "react";
import ReactDOM from "react-dom";

const name = "Dev";
 
//ReactDOM.render("WHAT TO SHOW ","WHERE TO SHOW IT ?");
ReactDOM.render(
<div>
<h1 className="heading">HELLO {name}</h1><p>It's a Para </p>
</div>,
document.getElementById("root"));

  