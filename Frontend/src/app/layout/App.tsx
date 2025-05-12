import { ApolloClient, ApolloProvider, InMemoryCache } from '@apollo/client'
import CustomersDashboard from '../../features/customers/customersDashboard/CustomersDashboard'
import './styles.css'

const client = new ApolloClient({ cache: new InMemoryCache({
  typePolicies:{}


}), uri: 'http://localhost:5004/graphql/' });


function App() {


  return (
    <>
     <ApolloProvider client={client}>
      <CustomersDashboard />
     </ApolloProvider>
    </>
  )
}

export default App
