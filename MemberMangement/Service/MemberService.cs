using MemberMangement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using Member = MemberMangement.Models.Member;

namespace MemberMangement.Service
{
    public class MemberService
    {
        MemberManagementEntities db = new MemberManagementEntities();

        public List<Member> GetAllMember()
        {
            return db.Member.ToList();
        }

        public void  DelectMember(int id)
        {
            Member DelectmMember = db.Member.SingleOrDefault(x => x.id == id);
            db.Member.Remove(DelectmMember);
            db.SaveChanges();
        }

        public void AddMember(Member AddMember)
        {
            db.Member.Add(AddMember);
            db.SaveChanges();
        }
        public Member GetMemberById(int id)
        {
           return db.Member.Find(id); ;
        }

        public void EditMemberData(Member EditMember)
        {
            Member oldMember = GetMemberById(EditMember.id);
            oldMember.Name = EditMember.Name;
            oldMember.Age = EditMember.Age;
            oldMember.Address = EditMember.Address;
            oldMember.Ted = EditMember.Ted;
            db.SaveChanges();
        }

        
    }

}