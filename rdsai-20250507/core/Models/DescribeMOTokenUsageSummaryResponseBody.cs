// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMOTokenUsageSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeMOTokenUsageSummaryResponseBodyRecords> Records { get; set; }
        public class DescribeMOTokenUsageSummaryResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-rds-ds5jjo08hyz1g9orhs3y56l5cy3l3shm</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8000</para>
            /// </summary>
            [NameInMap("CacheTokens")]
            [Validation(Required=false)]
            public double? CacheTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-21</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public double? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qcy-apikey</para>
            /// </summary>
            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-flash</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public double? OutputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RequestCount")]
            [Validation(Required=false)]
            public long? RequestCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public double? TotalTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DescribeMOTokenUsageSummaryResponseBodySummary Summary { get; set; }
        public class DescribeMOTokenUsageSummaryResponseBodySummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>9000</para>
            /// </summary>
            [NameInMap("CacheTokens")]
            [Validation(Required=false)]
            public double? CacheTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public double? InputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public double? OutputTokens { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11000</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public double? TotalTokens { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
