﻿
/*=========================================
* Author: Administrator
* DateTime:2017/6/20 18:17:21
* Description:$safeprojectname$
==========================================*/

using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;


    public class ApplicationFacade : Facade
    {
        public new static IFacade Instance
        {
            get
            {
                if (null == m_instance)
                {
                    lock (m_staticSyncRoot)
                    {
                        if ( null == m_instance )
                        {
                            Debug.Log("构造Facade,此处会自动构造View、Controller和Model");
                            m_instance = new ApplicationFacade();
                        }
                    }
                }
                return m_instance;
            }
        }



        #region 重新核心类型的构造方法

        protected override void InitializeFacade()
        {
            base.InitializeFacade();
        }

        protected override void InitializeView()
        {
            base.InitializeView();
        }

        protected override void InitializeController()
        {
            base.InitializeController();
        }

        protected override void InitializeModel()
        {
            base.InitializeModel();
        }

        #endregion
    }
