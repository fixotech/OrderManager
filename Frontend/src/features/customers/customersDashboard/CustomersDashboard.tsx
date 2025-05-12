import { useGetCustomersQuery } from "../../../graphql/generated/schema";

export default function CustomersDashboard() {

  const { data:customersData, loading, error } = useGetCustomersQuery();
  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: {error.message}</p>;

  return (
    <div>
      <h1>Customers Dashboard</h1>
      <ul>
        {customersData?.customers?.map((customer) => (
          <li key={customer?.id}>
            {customer?.firstName} {customer?.lastName} - {customer?.email}
          </li>
        ))}
      </ul>
    </div>
  );
}
