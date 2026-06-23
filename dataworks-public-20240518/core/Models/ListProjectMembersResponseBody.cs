// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListProjectMembersResponseBodyPagingInfo : TeaModel {
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
            /// <para>The number of entries to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of Workspace members.</para>
            /// </summary>
            [NameInMap("ProjectMembers")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyPagingInfoProjectMembers> ProjectMembers { get; set; }
            public class ListProjectMembersResponseBodyPagingInfoProjectMembers : TeaModel {
                /// <summary>
                /// <para>The ID of the DataWorks Workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62136</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The roles assigned to the Workspace member.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyPagingInfoProjectMembersRoles> Roles { get; set; }
                public class ListProjectMembersResponseBodyPagingInfoProjectMembersRoles : TeaModel {
                    /// <summary>
                    /// <para>The code of the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>role_project_guest</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The name of the role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Visitors</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the role.</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>UserCustom</c>: A user-defined role.</para>
                    /// </description></item>
                    /// <item><description><para><c>System</c>: A system role.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>System</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The status of the Workspace member.</para>
                /// <list type="bullet">
                /// <item><description><para><c>Normal</c>: The member is active.</para>
                /// </description></item>
                /// <item><description><para><c>Forbidden</c>: The member is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123422344899</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The name of the DataWorks user.</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The total number of matching entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request, used to track logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBBBB1F-DD5E-5D8E-8F50-37F77460F056</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
