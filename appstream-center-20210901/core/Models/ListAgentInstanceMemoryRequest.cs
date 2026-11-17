// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAgentInstanceMemoryRequest : TeaModel {
        /// <summary>
        /// <para>Filters by the business platform to which the Agent belongs. If omitted, no restriction is applied to the business platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>Filters by Agent provider. If omitted, queries providers that support memory management. <c>JVSCopilot</c> is not supported for memory management in this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgenticComputer</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>Filters by business type code. If omitted, no restriction is applied to the business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of end user IDs to include in the query results. Exact match is applied. You can specify up to 200 IDs.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The list of end user IDs to exclude from the query results. You can specify up to 200 IDs. If used together with EndUserIds, these users are excluded from the inclusion scope.</para>
        /// </summary>
        [NameInMap("ExcludedEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserIds { get; set; }

        /// <summary>
        /// <para>Filters by the memory switch configured for the instance.</para>
        /// <list type="bullet">
        /// <item><description><c>ENABLED</c>: The instance memory switch is turned on.</description></item>
        /// <item><description><c>DISABLED</c>: The instance memory switch is turned off.
        /// If both values are specified, instances matching either status are returned.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("MemoryStatuses")]
        [Validation(Required=false)]
        public List<string> MemoryStatuses { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. If this parameter is not specified or is set to 0, the first page is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword used for inclusion matching. Specify the search field by using SearchType. If left empty, no keyword filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-d8ut</para>
        /// </summary>
        [NameInMap("SearchKeyword")]
        [Validation(Required=false)]
        public string SearchKeyword { get; set; }

        /// <summary>
        /// <para>The search scope for the keyword. Default value: <c>ALL</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>ALL</c>: Searches the resource ID, resource name, runtime ID, and end user ID.</description></item>
        /// <item><description><c>RESOURCE_ID</c>: Searches the resource ID.</description></item>
        /// <item><description><c>RESOURCE_NAME</c>: Searches the resource name.</description></item>
        /// <item><description><c>RUNTIME_ID</c>: Searches the runtime ID.</description></item>
        /// <item><description><c>END_USER_ID</c>: Searches the end user ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE_ID</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
