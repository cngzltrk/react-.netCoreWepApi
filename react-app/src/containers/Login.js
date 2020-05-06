import React, { useState, Component } from "react";
import { Button, FormGroup, Form, Label ,Input} from "reactstrap";
import "./Login.css";
import axios from 'axios';
import { render } from "react-dom";


export default class Login extends Component {
  

  function validateForm() {
    return email.length > 0 && password.length > 0;
  }

  onClickEvent =(e)=>{
    console.log("basıldı");
  }
render(
  return (
    <div className="Login">
      <form >
      <div className="container">
         <div className="row ">
           <div >
           <h1 className="font-weight-bold">Project Mail Box</h1>
            <h2>Welcome</h2>
            <FormGroup>
              <Label for="exampleEmail">Email</Label>
              <Input type="email" name="email" id="exampleEmail" placeholder="email" />
            </FormGroup>
            <FormGroup>
              <Label for="examplePassword">Password</Label>
              <Input type="password" name="password" id="examplePassword" placeholder="password" />
            </FormGroup>
            <Button onClick={this.onClickEvent()}>Submit</Button>
           </div>
         </div>
      
      </div>
      </form>
    </div>
  );
)
}
/*
handleClick =(event)=>{
    var apiBaseUrl = "http://localhost:5000/api/";
    var self = this;
    var payload={
    "email":this.state.username,
    "password":this.state.password
    }
    axios.post(apiBaseUrl+'login', payload)
    .then(function (response) {
    console.log(response);
    if(response.data.code == 200){
    console.log("Login successfull");
    var uploadScreen=[];
    uploadScreen.push(<UploadSreen appContext={self.props.appContext}/>)
    self.props.appContext.setState({loginPage:[],uploadScreen:uploadScreen})
    }
    else if(response.data.code == 404){
    console.log("Username password do not match");
    alert("username password do not match")
    }
    else{
    console.log("Username does not exists");
    alert("Username does not exist");
    }
    })
    .catch(function (error) {
    console.log(error);
    });
    }*/