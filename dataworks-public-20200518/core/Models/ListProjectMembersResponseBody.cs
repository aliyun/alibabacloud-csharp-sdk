// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyData Data { get; set; }
        public class ListProjectMembersResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The information of members in the DataWorks workspace.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyDataProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseBodyDataProjectMemberList : TeaModel {
                /// <summary>
                /// The type of the member. Valid values:
                /// 
                /// *   1: USER_ALIYUN, which indicates that the member is an Alibaba Cloud account.
                /// *   5: USER_UBACCOUNT, which indicates that the member is a RAM user.
                /// *   6: USER_STS_ROLE, which indicates that the member is a RAM role.
                /// </summary>
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// The name of the member.
                /// </summary>
                [NameInMap("ProjectMemberId")]
                [Validation(Required=false)]
                public string ProjectMemberId { get; set; }

                /// <summary>
                /// The roles that are assigned to the member.
                /// </summary>
                [NameInMap("ProjectMemberName")]
                [Validation(Required=false)]
                public string ProjectMemberName { get; set; }

                /// <summary>
                /// The ID of the role.
                /// </summary>
                [NameInMap("ProjectMemberType")]
                [Validation(Required=false)]
                public string ProjectMemberType { get; set; }

                /// <summary>
                /// The type of the role. Valid values:
                /// 
                /// *   0: SYSTEM, which indicates that the role is a built-in role.
                /// *   2: USER_CUSTOM, which indicates that the role is a custom role.
                /// </summary>
                [NameInMap("ProjectRoleList")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList> ProjectRoleList { get; set; }
                public class ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList : TeaModel {
                    [NameInMap("ProjectRoleCode")]
                    [Validation(Required=false)]
                    public string ProjectRoleCode { get; set; }

                    /// <summary>
                    /// The name of the role.
                    /// 
                    /// DataWorks provides built-in roles and allows you to create custom roles based on your business requirements. For more information about roles, see [Overview of users, roles, and permissions](~~295463~~).
                    /// </summary>
                    [NameInMap("ProjectRoleId")]
                    [Validation(Required=false)]
                    public int? ProjectRoleId { get; set; }

                    [NameInMap("ProjectRoleName")]
                    [Validation(Required=false)]
                    public string ProjectRoleName { get; set; }

                    /// <summary>
                    /// The code of the role.
                    /// 
                    /// DataWorks provides built-in roles and allows you to create custom roles based on your business requirements. For more information about roles, see [Overview of users, roles, and permissions](~~295463~~).
                    /// </summary>
                    [NameInMap("ProjectRoleType")]
                    [Validation(Required=false)]
                    public string ProjectRoleType { get; set; }

                }

                /// <summary>
                /// The nickname of the member.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The status of the member. Valid values:
            /// 
            /// *   0: NORMAL, which indicates that the member is in a normal state.
            /// *   1: FORBIDDEN, which indicates that the member is disabled.
            /// *   2: DELETED, which indicates that the member is deleted.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
