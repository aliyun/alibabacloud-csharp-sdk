// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseCreditUsageRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query dimension. Valid values: Workspace indicates a single workspace, and Account indicates all workspaces under the caller account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workspace</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end time of the query range passed in the request, exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The actual page number used for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The actual page size used for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The metering records on the current page. If SortBy is not specified, the records are sorted in descending order of request time.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListContextDatabaseCreditUsageRecordsResponseBodyRecords> Records { get; set; }
        public class ListContextDatabaseCreditUsageRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The credit consumption of this record. It is returned as a decimal string with up to 6 decimal places. 1 credit = 1 CNY. The amount is recorded at the time of metering and does not change with subsequent price adjustments. It is null when unpriced, which does not indicate zero consumption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0742</para>
            /// </summary>
            [NameInMap("Credits")]
            [Validation(Required=false)]
            public string Credits { get; set; }

            /// <summary>
            /// <para>The billing item of this record. Valid values: KnowledgeBaseRead (knowledge base read), MemoryRead (memory base read), MemoryWrite (memory base write), KnowledgeBaseWriteToken (knowledge base write token), and ContextGrowth (context growth).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContextGrowth</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The ID of the member that generated this record. Historical or system records may not have a member ID, in which case null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mb-abcdefghijklmno</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>The usage of this record. The unit is specified by Unit in the same record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74200</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <para>The request time when this metering record was generated, in ISO 8601 UTC time format ending with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:30:12Z</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            /// <summary>
            /// <para>The context growth sub-item. Recognized values include KnowledgeOrganization (knowledge organization), MemoryPromotion (memory promotion), KnowledgeReview (knowledge review), KnowledgeEvolution (knowledge evolution), and MemoryEvolution (memory evolution). null is returned for other billing items, missing sub-items, or unrecognized sub-items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KnowledgeReview</para>
            /// </summary>
            [NameInMap("SubItem")]
            [Validation(Required=false)]
            public string SubItem { get; set; }

            /// <summary>
            /// <para>The metering unit. Valid values: Count indicates the number of times, Token indicates the number of tokens, and MicroCredit indicates one millionth of a credit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MicroCredit</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which this record belongs. Even if queried by account, each record still indicates its workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-x9z4ctzed9gfu2w</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the OpenAPI request, which is used to troubleshoot call issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query range passed in the request, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of metering records that match the filter conditions, which is not affected by pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The ID of the queried workspace. This parameter has a value only when Dimension is Workspace. It is empty for the account dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
