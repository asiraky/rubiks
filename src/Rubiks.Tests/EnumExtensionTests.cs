using System;
using System.Linq;
using NUnit.Framework;
using Rubiks.Factory;

namespace Rubiks.Tests
{
    [TestFixture]
    public class EnumExtensionTests
    {
        [Flags]
        enum Thing { A = 1, B = 2, C = 4, D = 8, E = 16 }

        [Test]
        public void CanEnumerateSetFlagsInOrder()
        {
            const Thing things = Thing.A | Thing.C | Thing.E;
            var flags = things.EnumerateSetValues().ToList();
            
            Assert.AreEqual(3, flags.Count());
            Assert.AreEqual(Thing.A, flags[0]);
            Assert.AreEqual(Thing.C, flags[1]);
            Assert.AreEqual(Thing.E, flags[2]);
        }

        [Test]
        public void CanEnumerateSetFlagsOutOfOrder()
        {
            const Thing things = Thing.D | Thing.C | Thing.E;
            var flags = things.EnumerateSetValues().ToList();

            Assert.AreEqual(3, flags.Count());
            Assert.AreEqual(Thing.D, flags[0]);
            Assert.AreEqual(Thing.C, flags[1]);
            Assert.AreEqual(Thing.E, flags[2]);
        }
    }
}
