// リスト12-18

using System;
using System.Collections.Generic;
using System.Linq;

namespace Example{
    class Program{
        static void Main(string[] arg){
            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
            var query = books.Select(x => x.Title);
            foreach(var title in query){
                Console.WriteLine(title);
            }
        }
    }

    class Book{
       	public string Title {get; set;}
        public string Author {get; set;}
        public int Pages {get; set;}
        public int Rating {get; set;}

        public Book(string title, string author, int pages, int rating){
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }
	}
}