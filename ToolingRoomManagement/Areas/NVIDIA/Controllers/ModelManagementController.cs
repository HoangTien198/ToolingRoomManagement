﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolingRoomManagement.Areas.NVIDIA.Entities;
using ToolingRoomManagement.Areas.NVIDIA.Repositories;

namespace ToolingRoomManagement.Areas.NVIDIA.Controllers
{
    public class ModelManagementController : Controller
    {
        /* GET */
        public JsonResult GetModels()
        {
            try
            {
                var result = RModels.GetModels();

                return Json(new { status = true, result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetModel(int IdModel)
        {
            try
            {
                var result = RModels.GetModel(IdModel);
                return Json(new { status = true, data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        /* POST */
        public JsonResult CreateModel(Entities.Model model)
        {
            try
            {
                var result = RModels.CreateModel(model);

                return Json(new { status = true, data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult EditModel(Entities.Model model)
        {
            try
            {
                var result = RModels.UpdateModel(model);

                return Json(new { status = true, data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult DeleteModel(int IdModel)
        {
            try
            {
                var result = RModels.DeleteModel(new Entities.Model { Id = IdModel });

                return Json(new { status = true, data = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}