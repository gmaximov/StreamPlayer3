using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using StreamPlayer.App.Plugins;

namespace StreamPlayerTests
{
    [TestClass()]
    public class PluginsTests
    {
        class TestClass
        { }

        [TestMethod()]
        public void SelectPluginTest()
        {
            try
            {
                Plugins.SelectPlugin("test");
                Assert.Fail();
            }
            catch
            {
            }

            try
            {
                Plugins.RegisterPlugin("test", typeof(TestClass));
                Plugins.SelectPlugin("test");
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void RegisterPluginTest()
        {
            Dictionary<string, Type> expected = new Dictionary<string, Type>();
            expected["test"] = typeof(TestClass);

            Plugins.RegisterPlugin("test", typeof(TestClass));           

            CollectionAssert.AreEquivalent(expected, Plugins.plugins);
        }

        [TestMethod()]
        public void GetPluginsListTest()
        {
            Plugins.RegisterPlugin("test", typeof(TestClass));
            Plugins.RegisterPlugin("test2", typeof(TestClass));

            List<string> expected = new List<string>();
            expected.Add("test2");
            expected.Add("test");

            CollectionAssert.AreEquivalent(expected, Plugins.GetPluginsList());
        }
    }
}