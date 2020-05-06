import React, { Component } from 'react'
import { Collapse, Button, CardBody, Card ,Col,CardTitle, CardText} from 'reactstrap';
  

export default class Mesaj extends Component {
  
    state={
        isVisible:false
    }
    onClickEvent=()=>{
        this.setState({isVisible: !this.state.isVisible});
    }
    render() {
        return (
             <div>
      <Collapse isOpen={this.props.isVisible}>
          <div className="container">
              <div className="row">
              {
            this.props.mesajs.map(mesaj =>
                {
                    return(
                    <Col sm="6">
                        <Card body className="text-rigt margin5" inverse style={{ backgroundColor: '#333', borderColor: '#333' }}>
                        <CardTitle  style={{textAlign:'left'}} >{mesaj.subject}</CardTitle>
                        <CardText  style={{textAlign:'left'}}>{this.state.isVisible ? mesaj.content :ellipsify(mesaj.content)}</CardText>
                        <Button key={mesaj.id} onClick={()=>this.onClickEvent()}>Go detail</Button>
                        </Card>
                    </Col>
                    );
                }
                )
        }
              </div>
          </div>
    
      </Collapse>
    </div>
        )
    }
}
function ellipsify (str) {
    if (str.length > 10) {
        return (str.substring(0, 10) + "...");
    }
    else {
        return str;
    }
}