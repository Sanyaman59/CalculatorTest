﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Calculator
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("499d6e8f-7d24-4dd1-a2ff-1edadc703e0b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CalculatorRepository repository.
        /// </summary>
        public static CalculatorRepository repo = CalculatorRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.ClearButton' at 46;35.", repo.Calculator.ClearButtonInfo, new RecordItemIndex(0));
            repo.Calculator.ClearButton.Click("46;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at 51;15.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(1));
            repo.Calculator.NumberPad.Num1Button.Click("51;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num2Button' at 15;15.", repo.Calculator.NumberPad.Num2ButtonInfo, new RecordItemIndex(2));
            repo.Calculator.NumberPad.Num2Button.Click("15;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num3Button' at 26;19.", repo.Calculator.NumberPad.Num3ButtonInfo, new RecordItemIndex(3));
            repo.Calculator.NumberPad.Num3Button.Click("26;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num4Button' at 18;20.", repo.Calculator.NumberPad.Num4ButtonInfo, new RecordItemIndex(4));
            repo.Calculator.NumberPad.Num4Button.Click("18;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num5Button' at 27;24.", repo.Calculator.NumberPad.Num5ButtonInfo, new RecordItemIndex(5));
            repo.Calculator.NumberPad.Num5Button.Click("27;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.SomeText2' at 9;3.", repo.Calculator.SomeText2Info, new RecordItemIndex(6));
            repo.Calculator.SomeText2.Click("9;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.MinusButton' at 61;22.", repo.Calculator.MinusButtonInfo, new RecordItemIndex(7));
            repo.Calculator.MinusButton.Click("61;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at 38;31.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(8));
            repo.Calculator.NumberPad.Num1Button.Click("38;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at 40;31.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(9));
            repo.Calculator.NumberPad.Num1Button.Click("40;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.Text1' at 0;23.", repo.Calculator.Text1Info, new RecordItemIndex(10));
            repo.Calculator.Text1.Click("0;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.DecimalSeparatorButton' at 52;31.", repo.Calculator.NumberPad.DecimalSeparatorButtonInfo, new RecordItemIndex(11));
            repo.Calculator.NumberPad.DecimalSeparatorButton.Click("52;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.NumberPad.Num1Button' at 43;35.", repo.Calculator.NumberPad.Num1ButtonInfo, new RecordItemIndex(12));
            repo.Calculator.NumberPad.Num1Button.Click("43;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Calculator.EqualButton' at 15;34.", repo.Calculator.EqualButtonInfo, new RecordItemIndex(13));
            repo.Calculator.EqualButton.Click("15;34");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}