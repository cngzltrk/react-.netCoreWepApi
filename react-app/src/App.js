import React from "react";

import axios from "axios";
import "./App.css";
import Home from './containers/Home'
import Mesaj from './containers/Mesaj'
export default class App extends React.Component {
  state = {
    users: [],
    mesajs:[],
    okunmamıs:0,
    toplam:0,
    isVisible:false,
  };
  
  
  handleClickEvent(){
    this.setState({isVisible: !this.state.isVisible});
    console.log("basıldı");
  }
  componentDidMount() {
    axios.get("http://localhost:5000/api/user/1").then((res) => {
      const users = res.data;
      let okunmamıs ,toplam;
      if(users.mesajs!=null)
      {
        let s1=users.mesajs.filter(mesaj => mesaj.isRead!="0").length
        let s2=users.mesajs.length;
        this.setState({ 
          users:users,
          okunmamıs:s1,
          toplam:s2,
          mesajs:users.mesajs
      });

      }
      else
      {
        this.setState({ users:users,mesajs:""});

      }

      console.log(this.state.mesajs);
    });
  }

  render() {
    return (
      <div className="App">
       <Home users={this.state.users} okunmamıs={this.state.okunmamıs} toplam={this.state.toplam} onClickEvent={()=>this.handleClickEvent()}></Home>
       <Mesaj isVisible={this.state.isVisible} mesajs={this.state.mesajs}></Mesaj>
      </div>
    );
  }
}
