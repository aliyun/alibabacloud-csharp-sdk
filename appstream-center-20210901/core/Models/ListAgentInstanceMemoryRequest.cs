// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAgentInstanceMemoryRequest : TeaModel {
        /// <summary>
        /// <para>Filters results by the business platform to which the agent belongs. If this parameter is omitted, no restriction is applied to the business platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>Filters results by agent provider. If this parameter is omitted, the system queries providers that support memory management. <c>JVSCopilot</c> is not supported for memory management in this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgenticComputer</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>Filters results by business type code. If this parameter is omitted, no restriction is applied to the business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of end user IDs to be included in the query results. Exact matching is applied. Maximum value: 200.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The list of end user IDs to be excluded from the query results. Maximum value: 200. When used together with EndUserIds, these users are removed from the inclusion scope.</para>
        /// </summary>
        [NameInMap("ExcludedEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserIds { get; set; }

        /// <summary>
        /// <para>Filters results by the memory switch configured for the instance.</para>
        /// <list type="bullet">
        /// <item><description><c>ENABLED</c>: The instance memory switch is turned on.</description></item>
        /// <item><description><c>DISABLED</c>: The instance memory switch is turned off.
        /// If both values are passed, instances matching either status are returned.</description></item>
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
        /// <para>The keyword used for inclusion matching. Use SearchType to specify the search field. If this parameter is left empty, no keyword filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-d8ut</para>
        /// </summary>
        [NameInMap("SearchKeyword")]
        [Validation(Required=false)]
        public string SearchKeyword { get; set; }

        /// <summary>
        /// <para>The scope of the keyword search. Default value: <c>ALL</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>ALL</c>: Searches resource IDs, resource names, runtime IDs, and end user IDs.</description></item>
        /// <item><description><c>RESOURCE_ID</c>: Searches resource IDs.</description></item>
        /// <item><description><c>RESOURCE_NAME</c>: Searches resource names.</description></item>
        /// <item><description><c>RUNTIME_ID</c>: Searches runtime IDs.</description></item>
        /// <item><description><c>END_USER_ID</c>: Searches end user IDs.</description></item>
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
