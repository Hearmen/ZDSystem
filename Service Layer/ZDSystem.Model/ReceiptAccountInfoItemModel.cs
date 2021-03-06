﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZDSystem.Entity;
namespace ZDSystem.Model
{
    /// <summary>
    /// 实体:MChinnel 的列表页面Model
    /// </summary>
	public class ReceiptAccountInfoItemModel
    {
        private MReceiptAccountInfo _currentModel=new MReceiptAccountInfo();
        /// <summary>
        /// 当前实体元素
        /// </summary>
        public MReceiptAccountInfo CurrentModel
        {
            get { return _currentModel; }
            set { _currentModel = value; }
        }
        /// <summary>
        /// 主键编号
        /// </summary>
        public string Id{get;set;}

        /// <summary>
        /// 处理消息
        /// </summary>
        public string Message{get;set;}

    }
}