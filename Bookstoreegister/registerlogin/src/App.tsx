import React from 'react';
//import logo from './logo.svg';
//import './App.css';


import { ThemeProvider } from "@material-ui/core/styles";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import "./assets/css/style.css";
import { theme } from "./utils/theme";
import MainNavigation from "./components/MainNavigation";
import Header from "./components/header";
import Footer from "./components/footer";


const App :React.FC =() =>{
  return(
    <ThemeProvider theme={theme}>
    <React.Suspense fallback={<></>}>
      <BrowserRouter>
        <div className="wrapper">
        <Header />
          <main>
            <MainNavigation />
          </main>
          <Footer />
        </div>
        <ToastContainer />
      </BrowserRouter>
    </React.Suspense>
  </ThemeProvider>
  );
}
/*function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
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

    <ThemeProvider theme={theme}>
    <React.Suspense fallback={<></>}>
      <BrowserRouter>
        <div className="wrapper">
        <Header />
          <main>
            <MainNavigation />
          </main>
          <Footer />
        </div>
        <ToastContainer />
      </BrowserRouter>
    </React.Suspense>
  </ThemeProvider>
  );
}*/

export default App;
