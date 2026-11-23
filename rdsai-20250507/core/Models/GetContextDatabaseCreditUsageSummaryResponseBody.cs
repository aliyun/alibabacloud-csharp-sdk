// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseCreditUsageSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The bucketing results, sorted by BucketStart, Item, and SubItem in sequence. Unpriced records are included in Quantity and RecordCount, but not in Credits.</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public List<GetContextDatabaseCreditUsageSummaryResponseBodyBuckets> Buckets { get; set; }
        public class GetContextDatabaseCreditUsageSummaryResponseBodyBuckets : TeaModel {
            /// <summary>
            /// <para>The start time of the bucket, in ISO 8601 UTC time format ending with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("BucketStart")]
            [Validation(Required=false)]
            public string BucketStart { get; set; }

            /// <summary>
            /// <para>The total credit consumption of priced records in the bucket. The value is returned as a decimal string with up to 6 decimal places. 1 credit = 1 CNY. If all records are unpriced, the string 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2513</para>
            /// </summary>
            [NameInMap("Credits")]
            [Validation(Required=false)]
            public string Credits { get; set; }

            /// <summary>
            /// <para>The billing item corresponding to the bucket. Valid values: KnowledgeBaseRead (knowledge base read), MemoryRead (memory read), MemoryWrite (memory write), KnowledgeBaseWriteToken (knowledge base write token), and ContextGrowth (context evolution).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContextGrowth</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The total usage of all records in the bucket, including unpriced records. The unit is specified by Unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>251300</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <para>The number of metering records in the bucket, including unpriced records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RecordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            /// <summary>
            /// <para>The context evolution sub-item. Recognized values include KnowledgeOrganization (knowledge organization), MemoryPromotion (memory promotion), KnowledgeReview (knowledge review), KnowledgeEvolution (knowledge evolution), and MemoryEvolution (memory evolution). For other billing items, missing sub-items, or unrecognized sub-items, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MemoryEvolution</para>
            /// </summary>
            [NameInMap("SubItem")]
            [Validation(Required=false)]
            public string SubItem { get; set; }

            /// <summary>
            /// <para>The unit of measurement. Valid values: Count (number of times), Token (number of tokens), and MicroCredit (one millionth of a credit).</para>
            /// 
            /// <b>Example:</b>
            /// <para>MicroCredit</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The query dimension. Valid values: Workspace (a single workspace) and Account (all workspaces under the caller account).</para>
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
        /// <para>The actual bucketing granularity used. Valid values: Hour (hourly) and Day (daily). If the request parameter is omitted, the automatically selected granularity is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

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
        /// <para>The total credit consumption of priced records that meet the filter conditions within the query range. The value is returned as a decimal string with up to 6 decimal places. 1 credit = 1 CNY. If there are no priced records, the string 0 is returned. Unpriced records are not included in the total amount. Do not treat this value as the final bill amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2513</para>
        /// </summary>
        [NameInMap("TotalCredits")]
        [Validation(Required=false)]
        public string TotalCredits { get; set; }

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
