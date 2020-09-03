﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApp.Models
{
    public class Source
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Article
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }

    }
    public class NewsResult
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
}
