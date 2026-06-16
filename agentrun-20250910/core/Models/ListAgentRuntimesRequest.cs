// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimesRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by agent runtime name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-runtime</para>
        /// </summary>
        [NameInMap("agentRuntimeName")]
        [Validation(Required=false)]
        public string AgentRuntimeName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The service discovery resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123456</para>
        /// </summary>
        [NameInMap("discoveryResourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiscoveryResourceGroupId { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the resource group. This parameter is deprecated.</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The search mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("searchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>Filters the results by status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY,CREATING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters the results by system tags. Separate multiple tags with commas. This parameter supports only exact matches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ecs:tag1,acs:ecs:tag2</para>
        /// </summary>
        [NameInMap("systemTags")]
        [Validation(Required=false)]
        public string SystemTags { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>A comma-separated string of workspace IDs.</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
