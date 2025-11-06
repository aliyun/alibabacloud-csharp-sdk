// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupMetricDataResponseBody : TeaModel {
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public ListResourceGroupMetricDataResponseBodyMetricData MetricData { get; set; }
        public class ListResourceGroupMetricDataResponseBodyMetricData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUSpec</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListResourceGroupMetricDataResponseBodyMetricDataMetrics> Metrics { get; set; }
            public class ListResourceGroupMetricDataResponseBodyMetricDataMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1761184929633</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tSBOXZcAmk+akxRkwRuXnGQEsIDODyd5ulPqgytNTbLp4bhb7fuvz13FXtm87Kfl</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
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

    }

}
