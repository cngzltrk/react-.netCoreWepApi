import React, { Component } from "react";
import {  Jumbotron, Button } from "reactstrap";

export default class Home extends Component {
    constructor(props)
    {
        super(props);
    }
  render() {
      const {users,okunmamıs,toplam}= this.props
    return (
      <div className="container">
        <div className="row">
          <div className="col-md-2"></div>
          <div className="col-md-8">
            <Jumbotron>
              <h1 className="display-3">
                Hello, {users.userName}{" "}
                {users.userLastName}!
              </h1>

              <hr className="my-2" />
              <p className="lead">
    You have <span className="font-weight-bold"> {okunmamıs}  </span> 
    unread messages out of {toplam} total
              </p>
              <p className="lead">
                <Button color="primary" onClick={()=>this.props.onClickEvent()}>View Messages</Button>
              </p>
            </Jumbotron>
          </div>
        </div>
      </div>
    );
  }
}
