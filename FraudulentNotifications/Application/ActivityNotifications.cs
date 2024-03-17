namespace Application
{
    public static class ActivityNotifications
    {
        public static int getExpenditureNotifications(List<int> expenditure, int days)
        {
            int notifications = 0;
            List<int> expenditureList = new List<int>();

            // Inicializar los gastos anteriores con los primeros "days" valores.
            for (int i = 0; i < days; i++)
            {
                expenditureList.Add(expenditure[i]);
            }

            for (int i = days; i < expenditure.Count; i++)
            {
                // Calcular la mediana de los gastos anteriores.
                double median;
                List<int> sortedExpenditures = expenditureList.OrderBy(x => x).ToList();
                if (days % 2 == 0)
                {
                    median = (sortedExpenditures[days / 2 - 1] + sortedExpenditures[days / 2]) / 2.0;
                }
                else
                {
                    median = sortedExpenditures[days / 2];
                }

                // Verificar si se debe enviar una notificación.
                if (expenditure[i] >= 2 * median)
                {
                    notifications++;
                }

                // Actualizar la lista de gastos anteriores.
                expenditureList.RemoveAt(0); // Eliminar el gasto más antiguo.
                expenditureList.Add(expenditure[i]); // Agregar el nuevo gasto.
            }

            // Mostrar el número de notificaciones.
            Console.WriteLine("Número de notificaciones: " + notifications);

            return notifications;
        }
    }
}