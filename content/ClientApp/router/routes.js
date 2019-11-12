import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Hello from 'components/hello'
import About from 'components/about'
import Directives from 'components/Directives'
import DataBinding from 'components/DataBinding'
import Models from 'components/Models'
import Routes from 'components/Routes'
import Child from 'components/Child'
import ListRendering from 'components/Advanced/ListRendering'
import Computed from 'components/Advanced/Computed'

export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Home', icon: 'home' },
  { name: 'about', path: '/about', component: About, display: 'About Template', icon: 'info' },
  { name: 'counter', path: '/counter', component: CounterExample, display: 'Counter', icon: 'graduation-cap' },
  { name: 'fetch-data', path: '/fetch-data', component: FetchData, display: 'Data', icon: 'list' },
  { name: 'Hello', path: '/Hello', component: Hello, display: 'Hello Vue', icon: 'info' },
  { name: 'Directives', path: '/Directives', component: Directives, display: 'Directives', icon: 'list' },
  { name: 'DataBinding', path: '/DataBinding', component: DataBinding, display: 'DataBinding', icon: 'info' },
  { name: 'Models', path: '/Models', component: Models, display: 'Models', icon: 'info' },
  {
    name: 'Routes',
    path: '/Routes',
    component: Routes,
    display: 'Routes',
    icon: 'info',
    children: [
      { path: 'Child/:id', component: Child }
    ]
  },
  { name: 'ListRendering', path: '/ListRendering', component: ListRendering, display: 'ListRendering', icon: 'list' },
  { name: 'Computed', path: '/Computed', component: Computed, display: 'Computed', icon: 'graduation-cap' }
]
