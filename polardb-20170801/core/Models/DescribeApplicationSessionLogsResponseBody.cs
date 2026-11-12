// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationSessionLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeApplicationSessionLogsResponseBodyItems Items { get; set; }
        public class DescribeApplicationSessionLogsResponseBodyItems : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<DescribeApplicationSessionLogsResponseBodyItemsItems> Items { get; set; }
            public class DescribeApplicationSessionLogsResponseBodyItemsItems : TeaModel {
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public string Agent { get; set; }

                [NameInMap("Api")]
                [Validation(Required=false)]
                public string Api { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("DetailDurationMs")]
                [Validation(Required=false)]
                public long? DetailDurationMs { get; set; }

                [NameInMap("DetailIsError")]
                [Validation(Required=false)]
                public bool? DetailIsError { get; set; }

                [NameInMap("DetailStatus")]
                [Validation(Required=false)]
                public string DetailStatus { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StopReason")]
                [Validation(Required=false)]
                public string StopReason { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Thinking")]
                [Validation(Required=false)]
                public string Thinking { get; set; }

                [NameInMap("ThinkingSignature")]
                [Validation(Required=false)]
                public string ThinkingSignature { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("ToolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

                [NameInMap("TotalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UsageCacheRead")]
                [Validation(Required=false)]
                public long? UsageCacheRead { get; set; }

                [NameInMap("UsageCacheWrite")]
                [Validation(Required=false)]
                public long? UsageCacheWrite { get; set; }

                [NameInMap("UsageCostCacheRead")]
                [Validation(Required=false)]
                public long? UsageCostCacheRead { get; set; }

                [NameInMap("UsageCostCacheWrite")]
                [Validation(Required=false)]
                public long? UsageCostCacheWrite { get; set; }

                [NameInMap("UsageCostInput")]
                [Validation(Required=false)]
                public long? UsageCostInput { get; set; }

                [NameInMap("UsageCostOutput")]
                [Validation(Required=false)]
                public long? UsageCostOutput { get; set; }

                [NameInMap("UsageCostTotal")]
                [Validation(Required=false)]
                public long? UsageCostTotal { get; set; }

                [NameInMap("UsageInput")]
                [Validation(Required=false)]
                public long? UsageInput { get; set; }

                [NameInMap("UsageOutput")]
                [Validation(Required=false)]
                public long? UsageOutput { get; set; }

                [NameInMap("UsageTotalTokens")]
                [Validation(Required=false)]
                public long? UsageTotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log records returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of log records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
