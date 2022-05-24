var Blog = /** @class */ (function () {
    function Blog(BlogId, Url) {
        this.BlogId = BlogId;
        this.Url = Url;
    }
    return Blog;
}());
var Post = /** @class */ (function () {
    function Post(BlogId, PostId, Title, Content) {
        this.BlogId = BlogId;
        this.PostId = PostId;
        this.Title = Title;
        this.Content = Content;
    }
    return Post;
}());
