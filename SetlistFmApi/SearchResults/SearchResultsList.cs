﻿using System.Collections.Generic;

namespace SetlistFmApi.SearchResults
{
  public class SearchResultsList<T> : List<T>
    {
        public int Total { get; set; }

        public int Page { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
