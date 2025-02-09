using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//BOOK ROUTES

// GET ALL BOOKS
app.MapGet("/books", () =>
{
    return "get all books";
});

// GET BOOK BY ID
app.MapGet("/books/{id}", (HttpContext context) =>
{
    var bookID = context.Request.RouteValues["id"];
    return "get book with ID number" + " " + bookID;
});

// ADD BOOK
app.MapPost("/books", () =>
{
    return "add a book";
});

// DELETE BOOK

app.MapDelete("/books/{id}", (HttpContext context) =>
{
    var bookID = context.Request.RouteValues["id"];
    return "delete book with ID number" + " " + bookID;
});

// UPDATE BOOK
app.MapPut("/books/{id}", (HttpContext context) =>
{
    var bookID = context.Request.RouteValues["id"];
    return "update book with ID number" + " " + bookID;
});


//READER ROUTES

// GET ALL READERS
app.MapGet("/readers", () =>
{
    return "get all readers";
});

// GET READER BY ID
app.MapGet("/readers/{id}", (HttpContext context) =>
{
    var readerID = context.Request.RouteValues["id"];
    return "get reader with ID number" + " " + readerID;
});

// ADD READER
app.MapPost("/readers", () =>
{
    return "add a reader";
});

// DELETE READER

app.MapDelete("/readers/{id}", (HttpContext context) =>
{
    var readerID = context.Request.RouteValues["id"];
    return "delete reader with ID number" + " " + readerID;
});

// UPDATE READER
app.MapPut("/readers/{id}", (HttpContext context) =>
{
    var readerID = context.Request.RouteValues["id"];
    return "update reader with ID number" + " " + readerID;
});



// BORROWING ROUTES

app.MapGet("/borrowings", () =>
{
    return "get all borrowings";
});

// GET BORROWING BY ID
app.MapGet("/borrowings/{id}", (HttpContext context) =>
{
    var borrowingID = context.Request.RouteValues["id"];
    return "get borrowing with ID number" + " " + borrowingID;
});

// ADD BORROWING
app.MapPost("/borrowings", () =>
{
    return "add a borrowing";
});

// DELETE BORROWING
app.MapDelete("/borrowings/{id}", (HttpContext context) =>
{
    var borrowingID = context.Request.RouteValues["id"];
    return "delete borrowing with ID number" + " " + borrowingID;
});

// UPDATE BORROWING
app.MapPut("/borrowings/{id}", (HttpContext context) =>
{
    var borrowingID = context.Request.RouteValues["id"];
    return "update borrowing with ID number" + " " + borrowingID;
});

app.Run();
