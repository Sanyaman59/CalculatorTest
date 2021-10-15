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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Calculator
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CalculatorRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("34154824-d41a-4091-8ee2-96c80b0066be")]
    public partial class CalculatorRepository : RepoGenBaseFolder
    {
        static CalculatorRepository instance = new CalculatorRepository();
        CalculatorRepositoryFolders.CalculatorAppFolder _calculator;
        CalculatorRepositoryFolders.ExplorerAppFolder _explorer;

        /// <summary>
        /// Gets the singleton class instance representing the CalculatorRepository element repository.
        /// </summary>
        [RepositoryFolder("34154824-d41a-4091-8ee2-96c80b0066be")]
        public static CalculatorRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CalculatorRepository() 
            : base("CalculatorRepository", "/", null, 0, false, "34154824-d41a-4091-8ee2-96c80b0066be", ".\\RepositoryImages\\CalculatorRepository34154824.rximgres")
        {
            _calculator = new CalculatorRepositoryFolders.CalculatorAppFolder(this);
            _explorer = new CalculatorRepositoryFolders.ExplorerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("34154824-d41a-4091-8ee2-96c80b0066be")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Calculator folder.
        /// </summary>
        [RepositoryFolder("235a2825-f618-436f-b3bf-657757e5ca4a")]
        public virtual CalculatorRepositoryFolders.CalculatorAppFolder Calculator
        {
            get { return _calculator; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("c941e16e-fe08-4fad-8f25-a1f117888236")]
        public virtual CalculatorRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class CalculatorRepositoryFolders
    {
        /// <summary>
        /// The CalculatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("235a2825-f618-436f-b3bf-657757e5ca4a")]
        public partial class CalculatorAppFolder : RepoGenBaseFolder
        {
            CalculatorRepositoryFolders.NumberPadFolder _numberpad;
            RepoItemInfo _text5Info;
            RepoItemInfo _sometextInfo;
            RepoItemInfo _sometext1Info;
            RepoItemInfo _clearbuttonInfo;
            RepoItemInfo _xpower2buttonInfo;
            RepoItemInfo _equalbuttonInfo;
            RepoItemInfo _squarerootbuttonInfo;
            RepoItemInfo _minusbuttonInfo;
            RepoItemInfo _text1Info;
            RepoItemInfo _sometext2Info;

            /// <summary>
            /// Creates a new Calculator  folder.
            /// </summary>
            public CalculatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculator", "/winapp[@packagename='Microsoft.WindowsCalculator']", parentFolder, 30000, null, true, "235a2825-f618-436f-b3bf-657757e5ca4a", "")
            {
                _numberpad = new CalculatorRepositoryFolders.NumberPadFolder(this);
                _text5Info = new RepoItemInfo(this, "Text5", ".//button[@automationid='num5Button']/text[@name='5']", ".//text[@name='5']", 30000, null, "d571c586-4690-4fc2-8b27-891e186807eb");
                _sometextInfo = new RepoItemInfo(this, "SomeText", ".//button[@automationid='multiplyButton']/text[@name='']", ".//text[@name='']", 30000, null, "46ea0af1-a956-4d77-922b-e95a2ad82165");
                _sometext1Info = new RepoItemInfo(this, "SomeText1", ".//button[@automationid='equalButton']/text[@name='']", ".//text[@name='']", 30000, null, "47aff506-cf36-4a5c-be61-b61e26b737f8");
                _clearbuttonInfo = new RepoItemInfo(this, "ClearButton", "?/?/container[@automationid='DisplayControls']/button[@automationid='clearButton']", ".//button[@automationid='clearButton']", 30000, null, "2324924c-ad0e-45c3-8d79-c72c51a9db36");
                _xpower2buttonInfo = new RepoItemInfo(this, "Xpower2Button", "?/?/container[@automationid='StandardFunctions']/button[@automationid='xpower2Button']", ".//button[@automationid='xpower2Button']", 30000, null, "0e82c297-cfdb-4e28-8880-1d154051f4a0");
                _equalbuttonInfo = new RepoItemInfo(this, "EqualButton", "?/?/container[@automationid='StandardOperators']/button[@automationid='equalButton']", ".//button[@automationid='equalButton']", 30000, null, "5f28eaf8-8f60-43eb-8fa8-695e6b4f35ab");
                _squarerootbuttonInfo = new RepoItemInfo(this, "SquareRootButton", "?/?/container[@automationid='StandardFunctions']/button[@automationid='squareRootButton']", ".//button[@automationid='squareRootButton']", 30000, null, "46ff512c-9905-4d86-9fc1-36ac43a67ba5");
                _minusbuttonInfo = new RepoItemInfo(this, "MinusButton", "?/?/container[@automationid='StandardOperators']/button[@automationid='minusButton']", ".//button[@automationid='minusButton']", 30000, null, "cb97fd97-47b9-499f-a3b8-4dfdc37cec42");
                _text1Info = new RepoItemInfo(this, "Text1", ".//button[@automationid='num1Button']/text[@name='1']", ".//text[@name='1']", 30000, null, "6c693609-cd10-4aeb-9eed-944ae86725be");
                _sometext2Info = new RepoItemInfo(this, "SomeText2", ".//button[@automationid='squareRootButton']/text[@name='']", ".//text[@name='']", 30000, null, "43f79366-9db8-49cf-bc60-858bf78d1d5c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("235a2825-f618-436f-b3bf-657757e5ca4a")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("235a2825-f618-436f-b3bf-657757e5ca4a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text5 item.
            /// </summary>
            [RepositoryItem("d571c586-4690-4fc2-8b27-891e186807eb")]
            public virtual Ranorex.Text Text5
            {
                get
                {
                    return _text5Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text5 item info.
            /// </summary>
            [RepositoryItemInfo("d571c586-4690-4fc2-8b27-891e186807eb")]
            public virtual RepoItemInfo Text5Info
            {
                get
                {
                    return _text5Info;
                }
            }

            /// <summary>
            /// The SomeText item.
            /// </summary>
            [RepositoryItem("46ea0af1-a956-4d77-922b-e95a2ad82165")]
            public virtual Ranorex.Text SomeText
            {
                get
                {
                    return _sometextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SomeText item info.
            /// </summary>
            [RepositoryItemInfo("46ea0af1-a956-4d77-922b-e95a2ad82165")]
            public virtual RepoItemInfo SomeTextInfo
            {
                get
                {
                    return _sometextInfo;
                }
            }

            /// <summary>
            /// The SomeText1 item.
            /// </summary>
            [RepositoryItem("47aff506-cf36-4a5c-be61-b61e26b737f8")]
            public virtual Ranorex.Text SomeText1
            {
                get
                {
                    return _sometext1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SomeText1 item info.
            /// </summary>
            [RepositoryItemInfo("47aff506-cf36-4a5c-be61-b61e26b737f8")]
            public virtual RepoItemInfo SomeText1Info
            {
                get
                {
                    return _sometext1Info;
                }
            }

            /// <summary>
            /// The ClearButton item.
            /// </summary>
            [RepositoryItem("2324924c-ad0e-45c3-8d79-c72c51a9db36")]
            public virtual Ranorex.Button ClearButton
            {
                get
                {
                    return _clearbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ClearButton item info.
            /// </summary>
            [RepositoryItemInfo("2324924c-ad0e-45c3-8d79-c72c51a9db36")]
            public virtual RepoItemInfo ClearButtonInfo
            {
                get
                {
                    return _clearbuttonInfo;
                }
            }

            /// <summary>
            /// The Xpower2Button item.
            /// </summary>
            [RepositoryItem("0e82c297-cfdb-4e28-8880-1d154051f4a0")]
            public virtual Ranorex.Button Xpower2Button
            {
                get
                {
                    return _xpower2buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Xpower2Button item info.
            /// </summary>
            [RepositoryItemInfo("0e82c297-cfdb-4e28-8880-1d154051f4a0")]
            public virtual RepoItemInfo Xpower2ButtonInfo
            {
                get
                {
                    return _xpower2buttonInfo;
                }
            }

            /// <summary>
            /// The EqualButton item.
            /// </summary>
            [RepositoryItem("5f28eaf8-8f60-43eb-8fa8-695e6b4f35ab")]
            public virtual Ranorex.Button EqualButton
            {
                get
                {
                    return _equalbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The EqualButton item info.
            /// </summary>
            [RepositoryItemInfo("5f28eaf8-8f60-43eb-8fa8-695e6b4f35ab")]
            public virtual RepoItemInfo EqualButtonInfo
            {
                get
                {
                    return _equalbuttonInfo;
                }
            }

            /// <summary>
            /// The SquareRootButton item.
            /// </summary>
            [RepositoryItem("46ff512c-9905-4d86-9fc1-36ac43a67ba5")]
            public virtual Ranorex.Button SquareRootButton
            {
                get
                {
                    return _squarerootbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The SquareRootButton item info.
            /// </summary>
            [RepositoryItemInfo("46ff512c-9905-4d86-9fc1-36ac43a67ba5")]
            public virtual RepoItemInfo SquareRootButtonInfo
            {
                get
                {
                    return _squarerootbuttonInfo;
                }
            }

            /// <summary>
            /// The MinusButton item.
            /// </summary>
            [RepositoryItem("cb97fd97-47b9-499f-a3b8-4dfdc37cec42")]
            public virtual Ranorex.Button MinusButton
            {
                get
                {
                    return _minusbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MinusButton item info.
            /// </summary>
            [RepositoryItemInfo("cb97fd97-47b9-499f-a3b8-4dfdc37cec42")]
            public virtual RepoItemInfo MinusButtonInfo
            {
                get
                {
                    return _minusbuttonInfo;
                }
            }

            /// <summary>
            /// The Text1 item.
            /// </summary>
            [RepositoryItem("6c693609-cd10-4aeb-9eed-944ae86725be")]
            public virtual Ranorex.Text Text1
            {
                get
                {
                    return _text1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1 item info.
            /// </summary>
            [RepositoryItemInfo("6c693609-cd10-4aeb-9eed-944ae86725be")]
            public virtual RepoItemInfo Text1Info
            {
                get
                {
                    return _text1Info;
                }
            }

            /// <summary>
            /// The SomeText2 item.
            /// </summary>
            [RepositoryItem("43f79366-9db8-49cf-bc60-858bf78d1d5c")]
            public virtual Ranorex.Text SomeText2
            {
                get
                {
                    return _sometext2Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SomeText2 item info.
            /// </summary>
            [RepositoryItemInfo("43f79366-9db8-49cf-bc60-858bf78d1d5c")]
            public virtual RepoItemInfo SomeText2Info
            {
                get
                {
                    return _sometext2Info;
                }
            }

            /// <summary>
            /// The NumberPad folder.
            /// </summary>
            [RepositoryFolder("a6b8e445-8103-43f2-923d-7adfafc3c330")]
            public virtual CalculatorRepositoryFolders.NumberPadFolder NumberPad
            {
                get { return _numberpad; }
            }
        }

        /// <summary>
        /// The NumberPadFolder folder.
        /// </summary>
        [RepositoryFolder("a6b8e445-8103-43f2-923d-7adfafc3c330")]
        public partial class NumberPadFolder : RepoGenBaseFolder
        {
            RepoItemInfo _num3buttonInfo;
            RepoItemInfo _num5buttonInfo;
            RepoItemInfo _num8buttonInfo;
            RepoItemInfo _num1buttonInfo;
            RepoItemInfo _num2buttonInfo;
            RepoItemInfo _num4buttonInfo;
            RepoItemInfo _decimalseparatorbuttonInfo;

            /// <summary>
            /// Creates a new NumberPad  folder.
            /// </summary>
            public NumberPadFolder(RepoGenBaseFolder parentFolder) :
                    base("NumberPad", "?/?/container[@automationid='NumberPad']", parentFolder, 30000, null, false, "a6b8e445-8103-43f2-923d-7adfafc3c330", "")
            {
                _num3buttonInfo = new RepoItemInfo(this, "Num3Button", "button[@automationid='num3Button']", "", 30000, null, "7106d237-6884-4a1c-9d61-bfb27ddb8211");
                _num5buttonInfo = new RepoItemInfo(this, "Num5Button", "button[@automationid='num5Button']", "", 30000, null, "06eaa3e1-70f1-4b49-a8c9-ff3d4583e99f");
                _num8buttonInfo = new RepoItemInfo(this, "Num8Button", "button[@automationid='num8Button']", "", 30000, null, "384031e9-35a6-46a0-b105-89dc26a025f3");
                _num1buttonInfo = new RepoItemInfo(this, "Num1Button", "button[@automationid='num1Button']", "", 30000, null, "5b3f45eb-21f8-4c47-8fe6-6fa92874f072");
                _num2buttonInfo = new RepoItemInfo(this, "Num2Button", "button[@automationid='num2Button']", "", 30000, null, "1450ba6b-e884-4aa7-862a-1edfe60eb1ed");
                _num4buttonInfo = new RepoItemInfo(this, "Num4Button", "button[@automationid='num4Button']", "", 30000, null, "0e434290-46ab-4be3-a3e8-f57eccc64ed1");
                _decimalseparatorbuttonInfo = new RepoItemInfo(this, "DecimalSeparatorButton", "button[@automationid='decimalSeparatorButton']", "", 30000, null, "9603188b-a758-4f95-99fa-1360ea08c3a4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a6b8e445-8103-43f2-923d-7adfafc3c330")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a6b8e445-8103-43f2-923d-7adfafc3c330")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Num3Button item.
            /// </summary>
            [RepositoryItem("7106d237-6884-4a1c-9d61-bfb27ddb8211")]
            public virtual Ranorex.Button Num3Button
            {
                get
                {
                    return _num3buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num3Button item info.
            /// </summary>
            [RepositoryItemInfo("7106d237-6884-4a1c-9d61-bfb27ddb8211")]
            public virtual RepoItemInfo Num3ButtonInfo
            {
                get
                {
                    return _num3buttonInfo;
                }
            }

            /// <summary>
            /// The Num5Button item.
            /// </summary>
            [RepositoryItem("06eaa3e1-70f1-4b49-a8c9-ff3d4583e99f")]
            public virtual Ranorex.Button Num5Button
            {
                get
                {
                    return _num5buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num5Button item info.
            /// </summary>
            [RepositoryItemInfo("06eaa3e1-70f1-4b49-a8c9-ff3d4583e99f")]
            public virtual RepoItemInfo Num5ButtonInfo
            {
                get
                {
                    return _num5buttonInfo;
                }
            }

            /// <summary>
            /// The Num8Button item.
            /// </summary>
            [RepositoryItem("384031e9-35a6-46a0-b105-89dc26a025f3")]
            public virtual Ranorex.Button Num8Button
            {
                get
                {
                    return _num8buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num8Button item info.
            /// </summary>
            [RepositoryItemInfo("384031e9-35a6-46a0-b105-89dc26a025f3")]
            public virtual RepoItemInfo Num8ButtonInfo
            {
                get
                {
                    return _num8buttonInfo;
                }
            }

            /// <summary>
            /// The Num1Button item.
            /// </summary>
            [RepositoryItem("5b3f45eb-21f8-4c47-8fe6-6fa92874f072")]
            public virtual Ranorex.Button Num1Button
            {
                get
                {
                    return _num1buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num1Button item info.
            /// </summary>
            [RepositoryItemInfo("5b3f45eb-21f8-4c47-8fe6-6fa92874f072")]
            public virtual RepoItemInfo Num1ButtonInfo
            {
                get
                {
                    return _num1buttonInfo;
                }
            }

            /// <summary>
            /// The Num2Button item.
            /// </summary>
            [RepositoryItem("1450ba6b-e884-4aa7-862a-1edfe60eb1ed")]
            public virtual Ranorex.Button Num2Button
            {
                get
                {
                    return _num2buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num2Button item info.
            /// </summary>
            [RepositoryItemInfo("1450ba6b-e884-4aa7-862a-1edfe60eb1ed")]
            public virtual RepoItemInfo Num2ButtonInfo
            {
                get
                {
                    return _num2buttonInfo;
                }
            }

            /// <summary>
            /// The Num4Button item.
            /// </summary>
            [RepositoryItem("0e434290-46ab-4be3-a3e8-f57eccc64ed1")]
            public virtual Ranorex.Button Num4Button
            {
                get
                {
                    return _num4buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Num4Button item info.
            /// </summary>
            [RepositoryItemInfo("0e434290-46ab-4be3-a3e8-f57eccc64ed1")]
            public virtual RepoItemInfo Num4ButtonInfo
            {
                get
                {
                    return _num4buttonInfo;
                }
            }

            /// <summary>
            /// The DecimalSeparatorButton item.
            /// </summary>
            [RepositoryItem("9603188b-a758-4f95-99fa-1360ea08c3a4")]
            public virtual Ranorex.Button DecimalSeparatorButton
            {
                get
                {
                    return _decimalseparatorbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The DecimalSeparatorButton item info.
            /// </summary>
            [RepositoryItemInfo("9603188b-a758-4f95-99fa-1360ea08c3a4")]
            public virtual RepoItemInfo DecimalSeparatorButtonInfo
            {
                get
                {
                    return _decimalseparatorbuttonInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("c941e16e-fe08-4fad-8f25-a1f117888236")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _list1Info;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/desktop[@processname='explorer']", parentFolder, 30000, null, true, "c941e16e-fe08-4fad-8f25-a1f117888236", "")
            {
                _list1Info = new RepoItemInfo(this, "List1", "?/?/list[@controlid='1']", "?/?/list[@controlid='1']", 30000, null, "5cc42ff3-b555-45be-9954-bab73b5c0223");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c941e16e-fe08-4fad-8f25-a1f117888236")]
            public virtual Ranorex.Desktop Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Desktop>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c941e16e-fe08-4fad-8f25-a1f117888236")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The List1 item.
            /// </summary>
            [RepositoryItem("5cc42ff3-b555-45be-9954-bab73b5c0223")]
            public virtual Ranorex.List List1
            {
                get
                {
                    return _list1Info.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The List1 item info.
            /// </summary>
            [RepositoryItemInfo("5cc42ff3-b555-45be-9954-bab73b5c0223")]
            public virtual RepoItemInfo List1Info
            {
                get
                {
                    return _list1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}