using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class RouletteTest
    { 
        private IRoulette _uut;
        
        [SetUp]
        public void SetUp()
        {
            _uut = Substitute.For<IRoulette>();
        }

        [Test]
        public void GetRandomNumber_Spin_CorrectResult()
        {
           
        }
    }
}
