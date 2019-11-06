import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Hello from 'components/hello'
import About from 'components/about'
import Directives from 'components/Directives'

export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Home', icon: 'home' },
  { name: 'about', path: '/about', component: About, display: 'About Template', icon: 'info' },
  { name: 'counter', path: '/counter', component: CounterExample, display: 'Counter', icon: 'graduation-cap' },
  { name: 'fetch-data', path: '/fetch-data', component: FetchData, display: 'Data', icon: 'list' },
  { name: 'Hello', path: '/Hello', component: Hello, display: 'Hello Vue', icon: 'list' },
  { name: 'Directives', path: '/Directives', component: Directives, display: 'Directives', icon: 'list' }
]
