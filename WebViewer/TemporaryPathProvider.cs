﻿namespace TraceEventAPIServer
{
    public class TemporaryPathProvider : ITemporaryPathProvider
    {
        public string Path => @""; // TODO: make this config driven
    }
}