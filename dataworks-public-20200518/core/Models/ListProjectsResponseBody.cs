// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyPageResult PageResult { get; set; }
        public class ListProjectsResponseBodyPageResult : TeaModel {
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
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of DataWorks workspaces.</para>
            /// </summary>
            [NameInMap("ProjectList")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyPageResultProjectList> ProjectList { get; set; }
            public class ListProjectsResponseBodyPageResultProjectList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the development role is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: The development role is enabled.</description></item>
                /// <item><description><b>true</b>: The development role is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DisableDevelopment")]
                [Validation(Required=false)]
                public bool? DisableDevelopment { get; set; }

                /// <summary>
                /// <para>Indicates whether the workspace is the default workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes.</description></item>
                /// <item><description><b>0</b>: no.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public int? IsDefault { get; set; }

                /// <summary>
                /// <para>The description of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_describe</para>
                /// </summary>
                [NameInMap("ProjectDescription")]
                [Validation(Required=false)]
                public string ProjectDescription { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>466230</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_project</para>
                /// </summary>
                [NameInMap("ProjectIdentifier")]
                [Validation(Required=false)]
                public string ProjectIdentifier { get; set; }

                /// <summary>
                /// <para>The display name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_project</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The user ID of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13969939245****</para>
                /// </summary>
                [NameInMap("ProjectOwnerBaseId")]
                [Validation(Required=false)]
                public string ProjectOwnerBaseId { get; set; }

                /// <summary>
                /// <para>The status of the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AVAILABLE: The status value is 0, which indicates that the workspace is Normal.</description></item>
                /// <item><description>DELETED: The status value is 1, which indicates that the workspace is deleted.</description></item>
                /// <item><description>INITIALIZING: The status value is 2, which indicates that the workspace is being initialized.</description></item>
                /// <item><description>INIT_FAILED: The status value is 3, which indicates that the workspace failed to be initialized.</description></item>
                /// <item><description>FORBIDDEN: The status value is 4, which indicates that the workspace is manually disabled.</description></item>
                /// <item><description>DELETING: The status value is 5, which indicates that the workspace is being deleted.</description></item>
                /// <item><description>DEL_FAILED: The status value is 6, which indicates that the workspace failed to be deleted.</description></item>
                /// <item><description>FROZEN: The status value is 7, which indicates that the workspace is frozen due to overdue payment.</description></item>
                /// <item><description>UPDATING: The status value is 8, which indicates that the workspace is being updated (a compute engine is being added and initialized for the project).</description></item>
                /// <item><description>UPDATE_FAILED: The status value is 9, which indicates that the workspace failed to be updated (a compute engine failed to be added and initialized for the project).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ProjectStatus")]
                [Validation(Required=false)]
                public int? ProjectStatus { get; set; }

                /// <summary>
                /// <para>The status code of the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AVAILABLE: The status value is 0, which indicates that the workspace is Normal.</description></item>
                /// <item><description>DELETED: The status value is 1, which indicates that the workspace is deleted.</description></item>
                /// <item><description>INITIALIZING: The status value is 2, which indicates that the workspace is being initialized.</description></item>
                /// <item><description>INIT_FAILED: The status value is 3, which indicates that the workspace failed to be initialized.</description></item>
                /// <item><description>FORBIDDEN: The status value is 4, which indicates that the workspace is manually disabled.</description></item>
                /// <item><description>DELETING: The status value is 5, which indicates that the workspace is being deleted.</description></item>
                /// <item><description>DEL_FAILED: The status value is 6, which indicates that the workspace failed to be deleted.</description></item>
                /// <item><description>FROZEN: The status value is 7, which indicates that the workspace is frozen due to overdue payment.</description></item>
                /// <item><description>UPDATING: The status value is 8, which indicates that the workspace is being updated (a compute engine is being added and initialized for the project).</description></item>
                /// <item><description>UPDATE_FAILED: The status value is 9, which indicates that the workspace failed to be updated (a compute engine failed to be added and initialized for the project).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("ProjectStatusCode")]
                [Validation(Required=false)]
                public string ProjectStatusCode { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzbn7****</para>
                /// </summary>
                [NameInMap("ResourceManagerResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceManagerResourceGroupId { get; set; }

                /// <summary>
                /// <para>The visibility permission of MaxCompute tables. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: MaxCompute tables are not visible to users within the tenant.</description></item>
                /// <item><description><b>1</b>: MaxCompute tables are visible to users within the tenant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TablePrivacyMode")]
                [Validation(Required=false)]
                public int? TablePrivacyMode { get; set; }

                /// <summary>
                /// <para>The list of tags bound to the workspace.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyPageResultProjectListTags> Tags { get; set; }
                public class ListProjectsResponseBodyPageResultProjectListTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether a proxy account is used to access the MaxCompute engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: A proxy account is not used.</description></item>
                /// <item><description><b>true</b>: A proxy account is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseProxyOdpsAccount")]
                [Validation(Required=false)]
                public bool? UseProxyOdpsAccount { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20658801****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
