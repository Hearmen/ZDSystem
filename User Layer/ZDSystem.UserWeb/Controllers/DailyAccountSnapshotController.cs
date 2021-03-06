﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib4Net.Core;
using Lib4Net.Framework.Settings;
using Lib4Net.Comm;
using Lib4Net.Logs;
using ZDSystem.UserService;
using ZDSystem.Entity;
using ZDSystem.Model;
using ZDSystem.Utility;

namespace ZDSystem.UserWeb.Controllers
{
    /// <summary>
    /// Controller：DailyAccountSnapshot(每日账户快照)
    /// </summary>
    public class DailyAccountSnapshotController : MainBaseController
    {
        /// <summary>
        /// 显示列表页面数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
          return View(DailyAccountSnapshotService.Instance.Query(Request.QueryString));
        }
        /// <summary>
        /// 预览详细信息页面
        /// </summary>
        /// <param name="id">主键编号</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            return View(DailyAccountSnapshotService.Instance.Query(id));
        }       
        /// <summary>
        /// 保存或修改页面
        /// </summary>
        /// <param name="id">主键编号</param>
        /// <returns></returns>
        public ActionResult Item(string id)
        {
            return View(DailyAccountSnapshotService.Instance.QueryItem(id));
        }
        /// <summary>
        /// 预览页面
        /// </summary>
        /// <param name="id">主键编号</param>
        /// <returns></returns>
        public ActionResult View(string id)
        {
            return View(DailyAccountSnapshotService.Instance.View(id));
        }
        /// <summary>
        /// 保存实体数据
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        [HttpPost]
        public string Item()
        {
            MDailyAccountSnapshot entity=new MDailyAccountSnapshot();
            entity.SetData(Request.Form);
            entity.TrimEmptyProperty();
            string id = Request.Form["__id"];
            IResult result = DailyAccountSnapshotService.Instance.Save(id,entity);           
            return result.ToString();
        }
        /// <summary>
        /// 删除指定编号
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         [HttpPost]
        public string Delete(string id)
        {
            IResult result = DailyAccountSnapshotService.Instance.Delete(id);            
            return result.ToString();
        }
        

         

    }
}