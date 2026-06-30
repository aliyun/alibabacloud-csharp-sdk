// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMOTokenUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The cursor for the next page. An empty value indicates the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzNDUsInRzIjoiMjAyNi0wNC0wOFQwMDowMDowMFoifQ==</para>
        /// </summary>
        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of records returned.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeMOTokenUsageDetailResponseBodyRecords> Records { get; set; }
        public class DescribeMOTokenUsageDetailResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The consumer associated with the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16<b><b><b>4_rds_copilot</b></b>_public_cn-4</b>**02</para>
            /// </summary>
            [NameInMap("ConsumerName")]
            [Validation(Required=false)]
            public string ConsumerName { get; set; }

            /// <summary>
            /// <para>The additional information passed by the user in the extra_info field during the request. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;label&quot;: &quot;test&quot;}</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>The number of input tokens consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public double? InputTokens { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-*********6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The model that was called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-flash</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of output tokens consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public double? OutputTokens { get; set; }

            /// <summary>
            /// <para>The region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The request time in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            /// <summary>
            /// <para>The total number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TotalTokens")]
            [Validation(Required=false)]
            public double? TotalTokens { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The usage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
