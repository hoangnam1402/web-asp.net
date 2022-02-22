public class WebContext :  DbContext
{
    public Dbset<Product> Products { get; set; }

    public Dbset<Tag> Tags { get; set; }
    
    public WebContext(DbContextOptions<WebContext> options) : base(options) { }

}