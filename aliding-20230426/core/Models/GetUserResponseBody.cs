// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("admin")]
        [Validation(Required=false)]
        public bool? Admin { get; set; }

        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("boss")]
        [Validation(Required=false)]
        public bool? Boss { get; set; }

        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        [NameInMap("deptOrderList")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyDeptOrderList> DeptOrderList { get; set; }
        public class GetUserResponseBodyDeptOrderList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

        }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("exclusiveAccount")]
        [Validation(Required=false)]
        public bool? ExclusiveAccount { get; set; }

        [NameInMap("exclusiveAccountCorpId")]
        [Validation(Required=false)]
        public string ExclusiveAccountCorpId { get; set; }

        [NameInMap("exclusiveAccountCorpName")]
        [Validation(Required=false)]
        public string ExclusiveAccountCorpName { get; set; }

        [NameInMap("exclusiveAccountType")]
        [Validation(Required=false)]
        public string ExclusiveAccountType { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("hideMobile")]
        [Validation(Required=false)]
        public bool? HideMobile { get; set; }

        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        [NameInMap("leaderInDept")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyLeaderInDept> LeaderInDept { get; set; }
        public class GetUserResponseBodyLeaderInDept : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("leader")]
            [Validation(Required=false)]
            public bool? Leader { get; set; }

        }

        [NameInMap("loginId")]
        [Validation(Required=false)]
        public string LoginId { get; set; }

        [NameInMap("managerUserid")]
        [Validation(Required=false)]
        public string ManagerUserid { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("orgEmail")]
        [Validation(Required=false)]
        public string OrgEmail { get; set; }

        [NameInMap("realAuthed")]
        [Validation(Required=false)]
        public bool? RealAuthed { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyRoleList> RoleList { get; set; }
        public class GetUserResponseBodyRoleList : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("senior")]
        [Validation(Required=false)]
        public bool? Senior { get; set; }

        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("unionEmpExt")]
        [Validation(Required=false)]
        public GetUserResponseBodyUnionEmpExt UnionEmpExt { get; set; }
        public class GetUserResponseBodyUnionEmpExt : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("unionEmpMapList")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
            public class GetUserResponseBodyUnionEmpExtUnionEmpMapList : TeaModel {
                [NameInMap("cropId")]
                [Validation(Required=false)]
                public string CropId { get; set; }

                [NameInMap("userid")]
                [Validation(Required=false)]
                public string Userid { get; set; }

            }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
