import { generatePath, useMatch } from 'react-router-dom';

/* eslint-disable @typescript-eslint/no-unused-vars */
type ExtractRouteParams<T> = string extends T
  ? Record<string, string | number | boolean>
  : T extends `${infer _Start}:${infer Param}/${infer Rest}`
    ? { [k in Param | keyof ExtractRouteParams<Rest>]: string | number | boolean }
    : T extends `${infer _Start}:${infer Param}`
      ? { [k in Param]: string | number | boolean }
      : {};
/* eslint-enable @typescript-eslint/no-unused-vars */

type PathParams<P extends string> = ExtractRouteParams<P>;

class NamedRoute<P extends string> {
  constructor(public path: P) {}

  generatePath(params: PathParams<P>) {
    return generatePath(this.path, params as any);
  }
}

export const useTypedRouteMatch = <T extends string>(route: NamedRoute<T>) => {
  const routeMatch = useMatch(route);
  return {
    pathParams: routeMatch?.params as PathParams<T> | undefined,
    ...routeMatch,
  };
};

export const routes = {
  overview: new NamedRoute('/overview'),
  profiles: new NamedRoute('/profiles'),
};
