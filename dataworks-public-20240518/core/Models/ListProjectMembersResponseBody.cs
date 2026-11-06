// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListProjectMembersResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the requested data.</para>
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
            [NameInMap("ProjectMembers")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyPagingInfoProjectMembers> ProjectMembers { get; set; }
            public class ListProjectMembersResponseBodyPagingInfoProjectMembers : TeaModel {
                /// <summary>
                /// <para>The ID of the DataWorks workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62136</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of workspace roles assigned to the workspace member.</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<ListProjectMembersResponseBodyPagingInfoProjectMembersRoles> Roles { get; set; }
                public class ListProjectMembersResponseBodyPagingInfoProjectMembersRoles : TeaModel {
                    /// <summary>
                    /// <para>The code of the workspace role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>role_project_guest</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The name of the workspace role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Visitors</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the workspace role. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>UserCustom: Custom role.</para>
                    /// </description></item>
                    /// <item><description><para>System: System role.</para>
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
                /// <para>The status of the workspace member. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Normal: Normal.</para>
                /// </description></item>
                /// <item><description><para>Forbidden: Disabled.</para>
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
                /// <para>The DataWorks account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123422344899</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The cloud account name of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liusan</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FBBBB1F-DD5E-5D8E-8F50-37F77460F056</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
