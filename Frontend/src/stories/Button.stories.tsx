import React from 'react';
import GradientButton from '../components/GradientButton';

export default { title: 'Button' };

export const gradient = (): React.ReactElement => (
  <GradientButton colorA="#5CC6EE" colorB="#3232ff">
    Button
  </GradientButton>
);
