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

        public ActionResult DelectMember(int id)
        {
            memberService.DelectMember(id);
            return RedirectToAction("index");
        }

        public ActionResult AddNewMember()
        {
            return View();
        }
//        public ActionResult Edit(int id)
//        {   
//            Member FindMember = new Member();
//            FindMember = memberService.FindMember(id);
//            return View(FindMember);
//        }

        [HttpPost]
        public ActionResult AddNewMember(Member Data)
        {
            memberService.AddMember(Data);
            return RedirectToAction("index");
        }
        public ActionResult Edit(int Id)
        {
            return View(memberService.GetMemberById(Id));
        }

    }
}