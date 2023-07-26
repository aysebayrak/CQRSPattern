namespace CQRS_Casgem.CQRSPatern.Queries
{

    public class GetProductGetByIdQuery
    {
        public GetProductGetByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
