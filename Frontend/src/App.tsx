import 'bootstrap-css-only/css/bootstrap.min.css';
import 'material-design-icons-iconfont/dist/material-design-icons.css';
import '@fortawesome/fontawesome-free/css/all.min.css';
import './components/animation.scss';
import './App.scss';

import * as React from 'react';
import { Route } from 'react-router';

import Layout from './components/Layout';
import Home from './view/Home';

const App: React.SFC = () => (
  <Layout>
    <Route exact path="/" component={Home} />
  </Layout>
);

export default App;
