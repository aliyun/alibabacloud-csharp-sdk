// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D7B2E70-F770-505B-A672-09F1D8F2EC1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type and quantity of resources that can be activated in a workspace. This list is returned when the Option is set to GetResourceLimits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxCompute_share: pay-as-you-go MaxCompute</description></item>
        /// <item><description>MaxCompute_isolate: subscription MaxCompute</description></item>
        /// <item><description>DLC_share: pay-as-you-go DLC</description></item>
        /// <item><description>PAI_Isolate: subscription PAI</description></item>
        /// <item><description>PAI_share: pay-as-you-go PAI</description></item>
        /// <item><description>DataWorks_isolate: subscription DataWorks</description></item>
        /// <item><description>DataWorks_share: pay-as-you-go DataWorks</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///    &quot;MaxCompute_share&quot;: 1,
        ///    &quot;MaxCompute_isolate&quot;: 1,
        ///    &quot;DLC_share&quot;: 1
        /// }</para>
        /// </summary>
        [NameInMap("ResourceLimits")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceLimits { get; set; }

        /// <summary>
        /// <para>The number of workspaces that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of workspace details. This list is returned when Option is set to GetWorkspaces.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyWorkspaces> Workspaces { get; set; }
        public class ListWorkspacesResponseBodyWorkspaces : TeaModel {
            /// <summary>
            /// <para>The names of the administrator accounts.</para>
            /// </summary>
            [NameInMap("AdminNames")]
            [Validation(Required=false)]
            public List<string> AdminNames { get; set; }

            /// <summary>
            /// <para>The user ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122424353535</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace description example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment types of the workspace.</para>
            /// </summary>
            [NameInMap("EnvTypes")]
            [Validation(Required=false)]
            public List<string> EnvTypes { get; set; }

            /// <summary>
            /// <para>the additional information. Only contains TenantId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;TenantId&quot;: &quot;4286******98&quot;}</para>
            /// </summary>
            [NameInMap("ExtraInfos")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfos { get; set; }

            /// <summary>
            /// <para>The time when the workspace was created. The time (UTC+0) follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ss.SSSZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the workspace was modified. The time (UTC+0) follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ss.SSSZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the workspace is the default workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The status of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace-example</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmwp7rky****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

    }

}
