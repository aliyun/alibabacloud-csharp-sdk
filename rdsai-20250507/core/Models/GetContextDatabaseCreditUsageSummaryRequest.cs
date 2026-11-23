// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseCreditUsageSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range, exclusive. This time must be later than StartTime. Use the ISO 8601 time format, such as 2026-10-15T00:00:00Z (UTC). The maximum time range is 7 days for hourly statistics and 31 days for daily statistics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The bucketing granularity. Valid values: Hour (hourly) and Day (daily). The values are case-insensitive. If omitted, Hour is used by default for a time range of up to 7 days, and Day is used for a time range exceeding 7 days. The maximum time range is 7 days for Hour and 31 days for Day. If the limit is exceeded, InvalidParameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The billing item used to filter records. Supported values include KnowledgeBaseRead (knowledge base read), MemoryRead (memory read), MemoryWrite (memory write), KnowledgeBaseWriteToken (knowledge base write token), and ContextGrowth (context evolution). If omitted, all billing items that consume credits are included. Storage items or unlisted values return InvalidParameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ContextGrowth</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// <para>The member ID used to filter records. If specified, WorkspaceId must also be provided. Otherwise, InvalidParameter is returned. A member ID is unique only within its workspace. This parameter only filters data and does not change the caller identity. Records without a member ID are not matched. Results are still bucketed by time and billing item, and are not split by member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mb-abcdefghijklmno</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The start time of the query range, inclusive. Use the ISO 8601 time format, such as 2026-09-15T00:00:00Z (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The context evolution sub-item used to filter records. Supported values include KnowledgeOrganization (knowledge organization), MemoryPromotion (memory promotion), KnowledgeReview (knowledge review), KnowledgeEvolution (knowledge evolution), and MemoryEvolution (memory evolution). The values are case-sensitive. If only SubItem is provided, the billing item is automatically restricted to ContextGrowth. If other Item values are provided simultaneously or the sub-item is not in the list, InvalidParameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MemoryEvolution</para>
        /// </summary>
        [NameInMap("SubItem")]
        [Validation(Required=false)]
        public string SubItem { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to query. If specified, only the data of this workspace under the caller account is queried. Locked workspaces can also be queried. If omitted, all workspaces under the caller account are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
