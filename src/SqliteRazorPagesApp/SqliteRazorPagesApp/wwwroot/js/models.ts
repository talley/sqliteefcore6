class Blog {

   private BlogId:number;
   private Url:string;
    public Posts: Post[];

    constructor(BlogId:number,Url:string) {
        this.BlogId = BlogId;
        this.Url = Url;
    }

}

class Post {

    private BlogId: number;
    private PostId: number;
    private Title: string;
    private Content: string;
    public Blog: Blog;


    constructor(BlogId: number, PostId: number, Title: string, Content: string) {
        this.BlogId = BlogId;
        this.PostId = PostId;
        this.Title = Title;
        this.Content = Content;
    }
}