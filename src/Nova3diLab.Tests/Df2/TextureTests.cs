﻿using System.IO;
using System.Linq;
using Nova3diLab.Df2;
using Xunit;

namespace Nova3diLab.Tests.Df2
{
    public class TextureTests
    {
        public static Texture Texture => new Texture("box", 0, 512, 512);
        
        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/texture.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(Texture)));
        }
    }
}