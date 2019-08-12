using System;
using System.Diagnostics;
using COMP123_S2019_Assignment5_SophiaBhullar301048344;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DollarComputersUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SelectForm selectForm;

        [TestMethod]
        public void TestThatSelectFormHasLoadedDataSource()
        {
            //ARRANGE
            //SelectForm selectForm;
            //ACT
            selectForm = new SelectForm();
            //selectForm.ShowInTaskbar = false;
            //selectForm.ShowDialog();
            //ASSERT
            Assert.IsTrue(selectForm.HasLoadedDataSource());
           
        }

        [TestMethod]
        public void TestThatSelectLabelDisplaysItemSelected()
        {
            //arrange
            //SelectForm selectForm;
            String outputString;
            //act
            selectForm = new SelectForm();
            selectForm.ShowInTaskbar = false;
            selectForm.ShowDialog();
            outputString = selectForm.SelectedHarwareTextBox.Text;

            //assert
            Assert.AreEqual("Asus G71GX-RX05 719.97",outputString);
        }
    }
}
