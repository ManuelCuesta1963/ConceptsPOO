namespace ConceptsPOO
{
    public class HourlyEmpleyee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:N2}",19}" +
                $"\n\tHours value..........: {$"{HourValue:C2}",19}" +
                $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",19}";
        }
    }
}
