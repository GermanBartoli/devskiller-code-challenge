# Bookstore Inventory with NUnit

## Introduction
You are working on a part of an inventory tracking app for a bookstore.
Your job is to finish code responsible for creating, updateing, deleting and fetching books.

## Problem Statement
To complete the task, you need to implement all methods in `BookRepository.cs` and `BooksController.cs` that are throwing NotImplementedExceptions right now:

1. `BookRepository.GetAllBooks` method, it should return all books from data context.
2. `BookRepository.GetBookById` method, it should return book by given id from data context, or null.
3. `BookRepository.AddBook` method, should return `true` and add book to the data context, if there is no book with same isbn yet, otherwise if there is already book with same isbn, or we're trying to add null object, method should return `false`.
4. `BookRepository.UpdateBook` method should update the data context with given book. If it succeess, it should return `true`. If we're trying to update null object, or trying to update isbn of book to another - already existing in database isbn, it should return `false`.
5. `BookRepository.DeleteBook` method shoud remove book with given id from the data context and return `true`, if book with given id does not exists, it should return `false`.

6. `BooksController.Create` post action should call repository method responsible for adding a book, if it succeeds, it should redirect to `Index` action, otherwise return `Create` view with model state error `Book creation failed`.
7. `BooksController.Update` post action should call repository method responsible for updateing the book if succeeds, it should redirect to `Index` action, otherwise return `Update` view with model state error `Book update failed` .
8. `BooksController.DeleteBook` post action should call repository method responsible for deleting a book, if it succeeds, it should redirect to `Index` action, otherwise return `NonFound` result.
9. `BooksController.Index` action should call repository method responsible for fetching all books.

## Hints
1. Book object consits of Id and couple of string fields. You don`t have to worry about any validation of those fields, expect ISBN number. This number should be uniqe (in terms of default string equality, in ex. "Abc" is not equal to "abc"). 
2. Please be aware that some user could try to add book with isbn already existing in database or try to update to exisiting isbn. In such cases methods responsive for such behavior in repository should return `false`, and BooksController should behave as decribed previously.
3. Remember that `BooksController.Update` will be provided with object instance that will be unrelated to any data context scope.
