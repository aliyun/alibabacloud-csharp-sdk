// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseCreditUsageRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range, exclusive. It must be later than StartTime. Use the ISO 8601 time format, such as <c>2026-10-15T00:00:00Z</c> (UTC). The maximum length of the query range is 31 days. If the limit is exceeded, InvalidParameter is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The billing item used to filter records. Valid values: KnowledgeBaseRead (knowledge base read), MemoryRead (memory base read), MemoryWrite (memory base write), KnowledgeBaseWriteToken (knowledge base write token), and ContextGrowth (context growth). If omitted, all billing items that consume credits are included. Storage items or unlisted values return InvalidParameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ContextGrowth</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// <para>The member ID used to filter records. If specified, WorkspaceId must also be provided. Otherwise, InvalidParameter is returned. A member ID is unique only within the workspace to which it belongs. This parameter only filters data and does not change the caller identity. Records without a member ID are not matched.</para>
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
        /// <para>The maximum number of records to return per page. Valid values: 1 to 200. Default value: 50. The pagination offset, calculated as (Page - 1) × PageSize, must not exceed 10,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field by which to sort the records. Only credits is supported. If omitted, the records are sorted in descending order of request time. Specifying a sort field does not change the total number of filtered records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credits</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: asc (ascending order) and desc (descending order). The values are case-insensitive. If SortBy is specified, the default value is desc. If only SortOrder is provided, InvalidParameter is returned. When sorting by credit, unpriced records are always placed at the end, and records with the same amount are sorted in descending order of request time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The start time of the query range, inclusive. Use the ISO 8601 time format, such as <c>2026-09-15T00:00:00Z</c> (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The context growth sub-item used to filter records. Valid values: KnowledgeOrganization (knowledge organization), MemoryPromotion (memory promotion), KnowledgeReview (knowledge review), KnowledgeEvolution (knowledge evolution), and MemoryEvolution (memory evolution). The values are case-sensitive. If only SubItem is provided, the billing item is automatically restricted to ContextGrowth. If other Item values are provided simultaneously or the sub-item is not in the list, InvalidParameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KnowledgeReview</para>
        /// </summary>
        [NameInMap("SubItem")]
        [Validation(Required=false)]
        public string SubItem { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to query. If specified, only the data of this workspace under the caller account is queried, and locked workspaces can also be queried. If omitted, all workspaces under the caller account are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
