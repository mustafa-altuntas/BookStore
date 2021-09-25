using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetByIdBook
{
    public class GetByIdBookQuery
    {
        private readonly BookStoreDbContext _dbContext;

        public GetByIdBookQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public GetByIdBookViewModel Handle(int id)
        {
            var book = _dbContext.Books.Where(x => x.Id == id).SingleOrDefault();
            if (book is null)
            {
                throw new NullReferenceException($"Verştabanında id değeri {id} olan bir kayıt bulunmamaktadır.");
            }
            GetByIdBookViewModel vm = new GetByIdBookViewModel
            {
                Title = book.Title,
                PageCount = book.PageCount,
                Genre = ((GenreEnum)book.GenreId).ToString(),
                PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy")
            };
            return vm;
        }
    }

    public class GetByIdBookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string PublishDate { get; set; }
    }
}