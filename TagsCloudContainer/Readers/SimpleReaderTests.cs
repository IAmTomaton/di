﻿using NUnit.Framework;

namespace TagsCloudContainer.Readers
{
    [TestFixture]
    class SimpleReaderTests
    {
        [Test]
        public void ReadAllLines_Docx()
        {
            var simpleReader = new SimpleReader(@"E:\Projects\Shpora1\di\TagsCloudContainer\Words.docx");

            var result = simpleReader.ReadAll();

            var expect = "A\nA\nA\nA\nD\nD\nB\nB\nD\nA\n";

            Assert.AreEqual(expect.Length, result.Length);
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void ReadAllLines_Doc()
        {
            var simpleReader = new SimpleReader(@"E:\Projects\Shpora1\di\TagsCloudContainer\Words.doc");

            var result = simpleReader.ReadAll();

            var expect = "A\nA\nA\nA\nD\nD\nB\nB\nD\nA\nD\n";

            Assert.AreEqual(expect.Length, result.Length);
            Assert.AreEqual(expect, result);
        }
    }
}