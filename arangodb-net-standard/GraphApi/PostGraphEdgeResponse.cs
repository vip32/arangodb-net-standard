﻿using System.Net;

namespace ArangoDBNetStandard.GraphApi
{
    public class PostGraphEdgeResponse
    {
        public PostGraphEdgeDefinitionGraph Graph { get; set; }

        public HttpStatusCode Code { get; set; }

        public bool Error { get; set; }

        public int ErrorNum { get; set; }
    }
}