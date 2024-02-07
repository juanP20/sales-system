using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Infrastructure.Helpers
{
    public static class QueryableHelper
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable,BasePaginationRequest reques)
        {
            return queryable.Skip((reques.NumPage - 1) * reques.Records).Take(reques.Records); 
                
        }
    }
}
 