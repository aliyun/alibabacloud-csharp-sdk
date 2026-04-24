// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMOTokenUsageDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeMOTokenUsageDetailResponseBodyRecords> Records { get; set; }
        public class DescribeMOTokenUsageDetailResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>16<b><b><b>4_rds_copilot</b></b>_public_cn-4</b>**02</para>
            /// </summary>
            [NameInMap("ConsumerName")]
            [Validation(Required=false)]
            public string ConsumerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds_copilot***_public_cn-*********6</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-flash</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public string RequestTime { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
