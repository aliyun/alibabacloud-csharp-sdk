// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("admin")]
        [Validation(Required=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("boss")]
        [Validation(Required=false)]
        public bool? Boss { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[2,3,4]</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("exclusiveAccount")]
        [Validation(Required=false)]
        public bool? ExclusiveAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("exclusiveAccountCorpId")]
        [Validation(Required=false)]
        public string ExclusiveAccountCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>组织名称</para>
        /// </summary>
        [NameInMap("exclusiveAccountCorpName")]
        [Validation(Required=false)]
        public string ExclusiveAccountCorpName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("exclusiveAccountType")]
        [Validation(Required=false)]
        public string ExclusiveAccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;爱好&quot;:&quot;旅游&quot;,&quot;年龄&quot;:&quot;24&quot;}</para>
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hideMobile")]
        [Validation(Required=false)]
        public bool? HideMobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1597573616828</para>
        /// </summary>
        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>login_id3</para>
        /// </summary>
        [NameInMap("loginId")]
        [Validation(Required=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager240</para>
        /// </summary>
        [NameInMap("managerUserid")]
        [Validation(Required=false)]
        public string ManagerUserid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18513027676</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>昵称</para>
        /// </summary>
        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
        /// </summary>
        [NameInMap("orgEmail")]
        [Validation(Required=false)]
        public string OrgEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("realAuthed")]
        [Validation(Required=false)]
        public bool? RealAuthed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>备注备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyRoleList> RoleList { get; set; }
        public class GetUserResponseBodyRoleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>职务</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("senior")]
        [Validation(Required=false)]
        public bool? Senior { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>010-86123456-2345</para>
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>技术总监</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("unionEmpExt")]
        [Validation(Required=false)]
        public GetUserResponseBodyUnionEmpExt UnionEmpExt { get; set; }
        public class GetUserResponseBodyUnionEmpExt : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("unionEmpMapList")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyUnionEmpExtUnionEmpMapList> UnionEmpMapList { get; set; }
            public class GetUserResponseBodyUnionEmpExtUnionEmpMapList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dingxxx</para>
                /// </summary>
                [NameInMap("cropId")]
                [Validation(Required=false)]
                public string CropId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("userid")]
                [Validation(Required=false)]
                public string Userid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("unionid")]
        [Validation(Required=false)]
        public string Unionid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>未来park</para>
        /// </summary>
        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
