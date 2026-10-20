// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListProjectRolesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListProjectRolesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the requested data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The list of workspace roles.</para>
            /// </summary>
            [NameInMap("ProjectRoles")]
            [Validation(Required=false)]
            public List<ListProjectRolesResponseBodyPagingInfoProjectRoles> ProjectRoles { get; set; }
            public class ListProjectRolesResponseBodyPagingInfoProjectRoles : TeaModel {
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
                /// <para>The list of DataWorks product module permissions granted to the role.</para>
                /// </summary>
                [NameInMap("ModulePermissions")]
                [Validation(Required=false)]
                public List<ListProjectRolesResponseBodyPagingInfoProjectRolesModulePermissions> ModulePermissions { get; set; }
                public class ListProjectRolesResponseBodyPagingInfoProjectRolesModulePermissions : TeaModel {
                    /// <summary>
                    /// <para>The ID of the DataWorks module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ModuleId")]
                    [Validation(Required=false)]
                    public long? ModuleId { get; set; }

                    /// <summary>
                    /// <para>The name of the DataWorks module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HoloStudio</para>
                    /// </summary>
                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    /// <summary>
                    /// <para>The type of the permission.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Read</para>
                    /// </summary>
                    [NameInMap("PermissionType")]
                    [Validation(Required=false)]
                    public string PermissionType { get; set; }

                }

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
                /// <para>The ID of the DataWorks workspace.</para>
                /// <para>Note: For default system workspace roles, the value of ProjectId is fixed to -1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21229</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the workspace role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the specified conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61649187-0BCF-5E75-8D4B-64FDBEBBB447</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
