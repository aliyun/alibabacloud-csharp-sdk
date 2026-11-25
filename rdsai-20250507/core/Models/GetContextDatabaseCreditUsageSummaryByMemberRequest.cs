// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseCreditUsageSummaryByMemberRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query interval, exclusive. It must be later than <c>StartTime</c>. Use the ISO 8601 time format, such as <c>2026-10-08T00:00:00Z</c> (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-08T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The billing item used to filter records. Supported values include KnowledgeBaseRead (knowledge base read), MemoryRead (memory read), MemoryWrite (memory write), KnowledgeBaseWriteToken (knowledge base write token), and ContextGrowth (context growth). If omitted, all billing items that consume credits are included. Specifying storage items or unlisted values returns an <c>InvalidParameter</c> error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MemoryWrite</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// <para>The member ID used to filter the aggregated results. If specified, only this member is analyzed without changing the caller identity. An empty list is returned if no matching records are found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mb-abcdefghijklmno</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The maximum number of members to return per page. Valid values: 1 to 200. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query interval, inclusive. Use the ISO 8601 time format, such as <c>2026-10-01T00:00:00Z</c> (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to be analyzed. This parameter is required. The workspace must belong to the caller&quot;s account. Locked workspaces can still be queried. Member IDs are unique only within their respective workspaces, and cross-workspace ranking is not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
