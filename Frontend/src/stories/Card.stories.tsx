import React from 'react';
import 'bootstrap-css-only/css/bootstrap.min.css';
import Card from '../components/Card';
import { CardTitle, CardText, CardSubtitle, Button, CardBody } from 'reactstrap';
import CardImg from '../components/CardImg';
export default { title: 'Card' };

export const top = () => (
  <Card style={{ maxWidth: '200px' }}>
    <CardImg
      style={{ maxWidth: '200px' }}
      top
      src="https://placeholder.pics/svg/200"
      alt="Card image cap"
    />
    <CardBody>
      <CardTitle>Card title</CardTitle>
      <CardSubtitle>Card subtitle</CardSubtitle>
      <CardText>
        Some quick example text to build on the card title and make up the bulk of the card's
        content.
      </CardText>
      <Button>Button</Button>
    </CardBody>
  </Card>
);
export const bottom = () => (
  <Card style={{ maxWidth: '200px' }}>
    <CardBody>
      <CardTitle>Card title</CardTitle>
      <CardSubtitle>Card subtitle</CardSubtitle>
      <CardText>
        Some quick example text to build on the card title and make up the bulk of the card's
        content.
      </CardText>
      <Button>Button</Button>
    </CardBody>
    <CardImg bottom src="https://placeholder.pics/svg/200" alt="Card image cap" />
  </Card>
);

export const left = () => (
  <Card lr>
    <CardImg
      style={{ maxWidth: '200px' }}
      left
      src="https://placeholder.pics/svg/200"
      alt="Card image cap"
    />
    <CardBody>
      <CardTitle>Card title</CardTitle>
      <CardSubtitle>Card subtitle</CardSubtitle>
      <CardText>
        Some quick example text to build on the card title and make up the bulk of the card's
        content.
      </CardText>
      <Button>Button</Button>
    </CardBody>
  </Card>
);

export const right = () => (
  <Card lr>
    <CardBody>
      <CardTitle>Card title</CardTitle>
      <CardSubtitle>Card subtitle</CardSubtitle>
      <CardText>
        Some quick example text to build on the card title and make up the bulk of the card's
        content.
      </CardText>
      <Button>Button</Button>
    </CardBody>
    <CardImg
      style={{ maxWidth: '200px' }}
      right
      src="https://placeholder.pics/svg/200"
      alt="Card image cap"
    />
  </Card>
);

export const hover = () => (
  <Card style={{ maxWidth: '300px' }}>
    <figure className="effect-bubba">
      <img src="https://via.placeholder.com/300" alt="img02" />
      <figcaption>
        <h2>
          Fresh <span>Bubba</span>
        </h2>
        <p>Bubba likes to appear out of thin air.</p>
        <a href="#">View more</a>
      </figcaption>
    </figure>
  </Card>
);
