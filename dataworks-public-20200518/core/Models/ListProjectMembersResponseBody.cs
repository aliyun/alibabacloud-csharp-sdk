// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyData Data { get; set; }
        public class ListProjectMembersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
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
            /// <para>The list of workspace members.</para>
            /// </summary>
            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyDataProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseBodyDataProjectMemberList : TeaModel {
                /// <summary>
                /// <para>The nickname of the workspace member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// <para>The user ID of the member.</para>
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
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("ProjectMemberName")]
                [Validation(Required=false)]
                public string ProjectMemberName { get; set; }

                /// <summary>
                /// <para>The type of the member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Alibaba Cloud account (USER_ALIYUN).</description></item>
                /// <item><description>5: RAM user (USER_UBACCOUNT).</description></item>
                /// <item><description>6: RAM role (USER_STS_ROLE).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ProjectMemberType")]
                [Validation(Required=false)]
                public string ProjectMemberType { get; set; }

                /// <summary>
                /// <para>The list of roles assigned to the member.</para>
                /// </summary>
                [NameInMap("ProjectRoleList")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList> ProjectRoleList { get; set; }
                public class ListProjectMembersResponseBodyDataProjectMemberListProjectRoleList : TeaModel {
                    /// <summary>
                    /// <para>The role code. DataWorks provides preset roles. You can also create custom roles based on your business requirements. For more information about roles, see <a href="https://help.aliyun.com/document_detail/295463.html">Overview of users, roles, and permissions</a>.</para>
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
                    /// <para>The name of the role. DataWorks provides preset roles. You can also create custom roles based on your business requirements. For more information about roles, see <a href="https://help.aliyun.com/document_detail/295463.html">Overview of users, roles, and permissions</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Visitor</para>
                    /// </summary>
                    [NameInMap("ProjectRoleName")]
                    [Validation(Required=false)]
                    public string ProjectRoleName { get; set; }

                    /// <summary>
                    /// <para>The type of the role. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>SYSTEM (0): system role.</para>
                    /// </description></item>
                    /// <item><description><para>USER_CUSTOM (2): custom role.</para>
                    /// </description></item>
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
                /// <para>The query status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Normal (NORMAL).</description></item>
                /// <item><description>1: Disabled (FORBIDDEN).</description></item>
                /// <item><description>2: Deleted (DELETED).</description></item>
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
