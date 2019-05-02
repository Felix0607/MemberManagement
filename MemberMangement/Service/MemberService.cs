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
        MemberManagementEntities1 db = new MemberManagementEntities1();

        #region display all list
        public List<Member> GetAllMember()
        {
            return db.Member.ToList();
        }
        #endregion

        #region delete data
        public void  DeleteMember(int id)
        {
            Member DeletemMember = db.Member.SingleOrDefault(x => x.id == id);
            db.Member.Remove(DeletemMember);
            db.SaveChanges();
        }
        #endregion

        #region add member
        public void AddMember(Member AddMember)
        {
            db.Member.Add(AddMember);
            db.SaveChanges();
        }
        public Member GetMemberById(int id)
        {
           return db.Member.Find(id); 
        }
        #endregion

        #region editdata
        public void EditMemberData(Member EditMember)
        {
            Member oldMember = GetMemberById(EditMember.id);
            oldMember.Name = EditMember.Name;
            oldMember.Age = EditMember.Age;
            oldMember.Address = EditMember.Address;
            oldMember.Ted = EditMember.Ted;
            db.SaveChanges();
        }
        #endregion


    }

}