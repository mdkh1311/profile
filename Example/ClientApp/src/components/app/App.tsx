import React from 'react';
import { BrowserRouter, Navigate, Route, Routes } from 'react-router-dom';
import { routes } from '../../routes';
import { Overview } from '../overview/Overview';
import { Profiles } from '../profiles/Profiles';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route element={<Overview />} path={routes.overview.path} />
          <Route element={<Profiles />} path={routes.profiles.path} />
          <Route
            index
            element={<Navigate to={routes.profiles.path} />}
          />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
