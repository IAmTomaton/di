﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TagsCloudContainer.Readers
{
    class SimpleReader : IReader
    {
        private string path { get; }

        public SimpleReader(string path)
        {
            this.path = path;
        }

        public string[] ReadAllLines()
        {
            var stream = new StreamReader(path);
            return stream.ReadToEnd().Split('\n');
        }
    }
}