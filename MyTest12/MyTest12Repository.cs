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

namespace MyTest12
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest12Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("d76bdeac-59d4-46ef-ada4-17dd477ca6e1")]
    public partial class MyTest12Repository : RepoGenBaseFolder
    {
        static MyTest12Repository instance = new MyTest12Repository();
        MyTest12RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest12Repository element repository.
        /// </summary>
        [RepositoryFolder("d76bdeac-59d4-46ef-ada4-17dd477ca6e1")]
        public static MyTest12Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest12Repository() 
            : base("MyTest12Repository", "/", null, 0, false, "d76bdeac-59d4-46ef-ada4-17dd477ca6e1", ".\\RepositoryImages\\MyTest12Repositoryd76bdeac.rximgres")
        {
            _rxmainframe = new MyTest12RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d76bdeac-59d4-46ef-ada4-17dd477ca6e1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("9c71302c-7742-4d79-89fc-b8a186476170")]
        public virtual MyTest12RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest12RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("9c71302c-7742-4d79-89fc-b8a186476170")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "9c71302c-7742-4d79-89fc-b8a186476170", "")
            {
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/button[@controlname='btnSubmitUserName']", ".//button[@controlname='btnSubmitUserName']", 30000, null, "6c3354b4-f735-41b7-ae95-05a224838f24");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9c71302c-7742-4d79-89fc-b8a186476170")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9c71302c-7742-4d79-89fc-b8a186476170")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("6c3354b4-f735-41b7-ae95-05a224838f24")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("6c3354b4-f735-41b7-ae95-05a224838f24")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
