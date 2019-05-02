using MemberMangement.Models;
using MemberMangement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberMangement.Controllers
{
    public class MemberController : Controller
    {
        MemberService memberService = new MemberService();
        // GET: Member
        public ActionResult Index()
        {
            List<Member> MemberList = new List<Member>();
            MemberList = memberService.GetAllMember();
            return View(MemberList);
        }

        public ActionResult DeleteMember(int id)
        {
            memberService.DeleteMember(id);
            return RedirectToAction("index");
        }

        public ActionResult AddNewMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewMember(Member Data)
        {
            memberService.AddMember(Data);
            return RedirectToAction("index", "Member");
        }

        [HttpPost]
        public ActionResult Edit(Member MemberData)
        {
            memberService.EditMemberData(MemberData);
            return RedirectToAction("index" , "Member");
        }

        public ActionResult EditView(int Id)
        {
            return View(memberService.GetMemberById(Id));
        }

    }
}