
using System;

public class UpdateBookModel
{
    public string Title { get; set; }
    public int GenreId { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
}

public class GetByIdBookViewModel
{
    public string Title { get; set; }
    public int PageCount { get; set; }
    public string Genre { get; set; }
    public string PublishDate { get; set; }
}
