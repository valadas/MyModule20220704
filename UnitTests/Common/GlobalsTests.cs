using Eraware.Modules.MyModule20220704.Common;
using System;
using Xunit;

namespace UnitTests.Common
{
    public class GlobalsTests
    {
        [Fact]
        public void ModulePrefixIsValid()
        {
            var modulePrefix = Globals.ModulePrefix;
            Assert.Equal(expected: "Era_MyModule20220704_", modulePrefix);
        }
    }
}
