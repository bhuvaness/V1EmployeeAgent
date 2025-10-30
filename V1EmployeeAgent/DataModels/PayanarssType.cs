namespace EmployeeDataAgent.DataModels
{
    public class PayanarssApplication
    {
        public PayanarssTypes Types { get; set; }
    }

    public class PayanarssType
    {
        public PayanarssTypes Children { get; set; }
        public Attributes ValuePairs { get; set; }
        public string AutoGenerate()
        {
            if (Children == null) return string.Empty;

            if (ValuePairs.Keys.Contains("100000000000000000000000000000018"))
                return NewGuid();
            else
                return string.Empty;
        }
        public string NewGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class PayanarssTypes : Dictionary<string, PayanarssType>
    {
        public void Create(PayanarssType payanarssType)
        {
            if (payanarssType == null || payanarssType.ValuePairs == null) return;

            if (payanarssType.ValuePairs.Keys.Contains("100000000000000000000000000000025"))
                ValidateBeforeCreate(payanarssType);
        }
        public void Read()
        {
        }
        public void Update()
        {
            ValidateBeforeUpdate();
        }
        public void Delete()
        {
            ValidateBeforeDelete();
        }
        public void ValidateBeforeCreate(PayanarssType payanarssType)
        {
            if (payanarssType == null || payanarssType.Children == null) return;

            foreach(var child in payanarssType.Children)
            {

            }
        }
        public void ValidateBeforeUpdate()
        {

        }
        public void ValidateBeforeDelete()
        {

        }
    }

    public class Attribute
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }
    public class Attributes : Dictionary<string, Attribute>
    {

    }
}
