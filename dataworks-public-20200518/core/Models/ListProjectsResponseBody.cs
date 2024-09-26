// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The results that are returned.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyPageResult PageResult { get; set; }
        public class ListProjectsResponseBodyPageResult : TeaModel {
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
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The DataWorks workspaces.</para>
            /// </summary>
            [NameInMap("ProjectList")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyPageResultProjectList> ProjectList { get; set; }
            public class ListProjectsResponseBodyPageResultProjectList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the Development role is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b>: enabled</description></item>
                /// <item><description><b>true</b>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DisableDevelopment")]
                [Validation(Required=false)]
                public bool? DisableDevelopment { get; set; }

                /// <summary>
                /// <para>Indicates whether the workspace is a default workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The workspace is a default workspace.</description></item>
                /// <item><description><b>0</b>: The workspace is not a default workspace.</description></item>
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
                /// <para>1212</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
                /// <para>The ID of the user used by the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122222</para>
                /// </summary>
                [NameInMap("ProjectOwnerBaseId")]
                [Validation(Required=false)]
                public string ProjectOwnerBaseId { get; set; }

                /// <summary>
                /// <para>The status of the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: AVAILABLE, which indicates that the workspace is running as expected.</description></item>
                /// <item><description>1: DELETED, which indicates that the workspace is deleted.</description></item>
                /// <item><description>2: INITIALIZING, which indicates that the workspace is being initialized.</description></item>
                /// <item><description>3: INIT_FAILED, which indicates that the workspace fails to be initialized.</description></item>
                /// <item><description>4: FORBIDDEN, which indicates that the workspace is manually disabled.</description></item>
                /// <item><description>5: DELETING, which indicates that the workspace is being deleted.</description></item>
                /// <item><description>6: DEL_FAILED, which indicates that the workspace fails to be deleted.</description></item>
                /// <item><description>7: FROZEN, which indicates that the workspace is frozen due to overdue payments.</description></item>
                /// <item><description>8: UPDATING, which indicates that the workspace is being updated. After you associate a compute engine with the workspace, the system initializes the compute engine and updates the workspace.</description></item>
                /// <item><description>9: UPDATE_FAILED, which indicates that the workspace fails to be updated.</description></item>
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
                /// <item><description>AVAILABLE: 0, which indicates that the workspace is running as expected.</description></item>
                /// <item><description>DELETED: 1, which indicates that the workspace is deleted.</description></item>
                /// <item><description>INITIALIZING: 2, which indicates that the workspace is being initialized.</description></item>
                /// <item><description>INIT_FAILED: 3, which indicates that the workspace fails to be initialized.</description></item>
                /// <item><description>FORBIDDEN: 4, which indicates that the workspace is manually disabled.</description></item>
                /// <item><description>DELETING: 5, which indicates that the workspace is being deleted.</description></item>
                /// <item><description>DEL_FAILED: 6, which indicates that the workspace fails to be deleted.</description></item>
                /// <item><description>FROZEN: 7, which indicates that the workspace is frozen due to overdue payments.</description></item>
                /// <item><description>UPDATING: 8, which indicates that the workspace is being updated. After you associate a compute engine with the workspace, the system initializes the compute engine and updates the workspace.</description></item>
                /// <item><description>UPDATE_FAILED: 9, which indicates that the workspace fails to be updated.</description></item>
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
                /// <para>rg-acfmzbn7pti3zfa</para>
                /// </summary>
                [NameInMap("ResourceManagerResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceManagerResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the MaxCompute tables in the workspace are visible to the users within a tenant. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invisible</description></item>
                /// <item><description><b>1</b>: visible</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TablePrivacyMode")]
                [Validation(Required=false)]
                public int? TablePrivacyMode { get; set; }

                /// <summary>
                /// <para>The tags added to the workspace.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyPageResultProjectListTags> Tags { get; set; }
                public class ListProjectsResponseBodyPageResultProjectListTags : TeaModel {
                    /// <summary>
                    /// <para>The key of tag N added to the workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Env</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of tag N added to the workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether a proxy account is used to access the MaxCompute compute engine associated with the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
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
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20658801***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
