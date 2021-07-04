using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.ENTITIES.Models;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVCUI.Controllers
{
    public class EditorController : Controller
    {
        readonly IEditorManager _iem;

        public EditorController(IEditorManager iem)
        {
            _iem = iem;
        }

        public IActionResult EditorList()
        {
            EditorVM evm = new EditorVM
            {
                Editors = _iem.GetActives()
            };
            return View(evm);
        }
        public IActionResult AddEditor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEditor(Editor editor)
        {
            TempData["message"] = _iem.Add(editor);
            return RedirectToAction("EditorList");
        }

        public IActionResult UpdateEditor(int id)
        {
            EditorVM evm = new EditorVM
            {
                Editor = _iem.Find(id)
            };
            return View(evm);
        }
        [HttpPost]
        public IActionResult UpdateEditor(Editor editor)
        {
            _iem.Update(editor);
            return RedirectToAction("EditorList");
        }

        public IActionResult DeleteEditor(int id)
        {
            _iem.Delete(_iem.Find(id));
            return RedirectToAction("EditorList");
        }
    }
}
