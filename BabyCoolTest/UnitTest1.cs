using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabyLibrary;

namespace BabyCoolTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CriticalHighTest()
        {
            string alarmresult = BabyCool.AlarmBreath(19);

            Assert.AreEqual("Critical High", alarmresult);
        }
        [TestMethod]
        public void HighEndOfNormalTest()
        {
            string alarmresult = BabyCool.AlarmBreath(18);

            Assert.AreEqual("Normal", alarmresult);
        }

        [TestMethod]
        public void AlarmBreathCriticalLowTest()
        {
            string alarmresult = BabyCool.AlarmBreath(11);

            Assert.AreEqual("Critical Low", alarmresult);
        }
        [TestMethod]
        public void AlarmBreathLowEndOfNormal()
        {
            string alarmresult = BabyCool.AlarmBreath(12);

            Assert.AreEqual("Normal", alarmresult);
        }
        [TestMethod]
        public void AlarmCryTrueTest()
        {
            var cryresult = BabyCool.AlarmCry(1);
            Assert.AreEqual(true, cryresult);
        }
        [TestMethod]
        public void AlarmCryFalseTest()
        {
            var cryresult = BabyCool.AlarmCry(0);
            Assert.AreEqual(false, cryresult);
        }





    }
}
