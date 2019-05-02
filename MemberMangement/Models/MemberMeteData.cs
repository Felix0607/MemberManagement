using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MemberMangement.Models
{
    [MetadataType(typeof(MemberMeteData))]
    public partial class Member {
        public class MemberMeteData
        {
            [DisplayName("會員編號")]
            public int id { get; set; }
            
            [DisplayName("會員名稱")]
            public string Name { get; set; }
            
            [DisplayName("年齡")]
            [Range(0, 100, ErrorMessage="會員年齡0-100歲")]
            public int Age { get; set; }
            
            [DisplayName("地址")]
            public string Address { get; set; }
            
            [DisplayName("電話")]
            [RegularExpression(@"^09\d{2}-\d{6}$",
                   ErrorMessage = "Entered phone format is not valid.09xx-xxxxxx")]
            public string Ted { get; set; }
        }

    }
    
}