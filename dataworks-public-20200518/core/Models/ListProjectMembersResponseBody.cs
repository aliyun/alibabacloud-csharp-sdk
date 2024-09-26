// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyData Data { get; set; }
        public class ListProjectMembersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The information about members in the DataWorks workspace.</para>
            /// </summary>
            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyDataProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseBodyDataProjectMemberList : TeaModel {
                /// <summary>
                /// <para>The nickname of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// <para>The member ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121</para>
                /// </summary>
                [NameInMap("ProjectMemberId")]
                [Validation(Required=false)]
                public string ProjectMemberId { get; set; }

                /// <summary>
                /// <para>The name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("ProjectMemberName")]
                [Validation(Required=false)]
                public string ProjectMemberName { get; set; }

                /// <summary>
                /// <para>The type of the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: USER_ALIYUN, which indicates that the member is an Alibaba Cloud account.</description></item>
                /// <item><description>5: USER_UBACCOUNT, which indicates that the member is a RAM user.</description></item>
                /// <item><description>6: USER_STS_ROLE, which indicates that the member is a RAM role.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProjectMemberType")]
                [Validation(Required=false)]
                public string ProjectMemberType { get; set; }

                /// <summary>
                /// <para>The roles that are assigned to the member.</para>
                /// </summary>
                [NameInMap("ProjectRoleList")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList> ProjectRoleList { get; set; }
                public class ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList : TeaModel {
                    /// <summary>
                    /// <para>The code of the role. DataWorks provides built-in roles and allows you to create custom roles based on your business requirements. For more information about roles, see <a href="https://help.aliyun.com/document_detail/295463.html">Overview of users, roles, and permissions</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>role_project_guest</para>
                    /// </summary>
                    [NameInMap("ProjectRoleCode")]
                    [Validation(Required=false)]
                    public string ProjectRoleCode { get; set; }

                    /// <summary>
                    /// <para>The role ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ProjectRoleId")]
                    [Validation(Required=false)]
                    public int? ProjectRoleId { get; set; }

                    /// <summary>
                    /// <para>The name of the role. DataWorks provides built-in roles and allows you to create custom roles based on your business requirements. For more information about roles, see <a href="https://help.aliyun.com/document_detail/295463.html">Overview of users, roles, and permissions</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ProjectRoleName")]
                    [Validation(Required=false)]
                    public string ProjectRoleName { get; set; }

                    /// <summary>
                    /// <para>The type of the role. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: SYSTEM, which indicates that the role is a built-in role.</description></item>
                    /// <item><description>2: USER_CUSTOM, which indicates that the role is a custom role.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ProjectRoleType")]
                    [Validation(Required=false)]
                    public string ProjectRoleType { get; set; }

                }

                /// <summary>
                /// <para>The status of the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: NORMAL, which indicates that the member is in a normal state.</description></item>
                /// <item><description>1: FORBIDDEN, which indicates that the member is disabled.</description></item>
                /// <item><description>2: DELETED, which indicates that the member is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
