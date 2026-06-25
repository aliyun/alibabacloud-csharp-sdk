// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListWorkspacesRequest : TeaModel {
        /// <summary>
        /// <para>The list of return fields for workspace details. This parameter limits the workspace properties returned in the result.
        /// Separate multiple properties with commas (,). Currently, only Id is supported, which represents the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The comma-separated list of modules. Default value: PAI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAI</para>
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public string ModuleList { get; set; }

        /// <summary>
        /// <para>The query option. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GetWorkspaces (default): retrieves the workspace list. The Workspaces parameter is returned.</description></item>
        /// <item><description>GetResourceLimits: retrieves resource limits. The ResourceLimits parameter is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GetWorkspaces</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The sort order for the specified sort field in a paged query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC (default): ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the workspace list. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID. For information about how to view the resource group ID, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwp7rky****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The field used for sorting in a paged query. Default value: GmtCreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreateTime (default): sorts by creation time.</description></item>
        /// <item><description>GmtModifiedTime: sorts by modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The workspace status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED: Normal.</description></item>
        /// <item><description>INITIALIZING: Being initialized.</description></item>
        /// <item><description>FAILURE: Failed.</description></item>
        /// <item><description>DISABLED: Manually disabled.</description></item>
        /// <item><description>FROZEN: Frozen due to overdue payment.</description></item>
        /// <item><description>UPDATING: Being updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display detailed workspace information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not display detailed information.</description></item>
        /// <item><description>true: displays detailed information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The list of workspace IDs. Separate multiple workspace IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,234</para>
        /// </summary>
        [NameInMap("WorkspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
