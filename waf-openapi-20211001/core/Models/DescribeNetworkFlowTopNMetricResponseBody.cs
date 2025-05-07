// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTopNMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The top statistical data array returned.</para>
        /// </summary>
        [NameInMap("NetworkFlowTopNValues")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues> NetworkFlowTopNValues { get; set; }
        public class DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues : TeaModel {
            /// <summary>
            /// <para>Returns additional information, such as the country, province, or city to which an IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The value of this field varies depending on the queried Metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Counts for top ranking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-D33C8B4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("TopNMetaData")]
        [Validation(Required=false)]
        public DescribeNetworkFlowTopNMetricResponseBodyTopNMetaData TopNMetaData { get; set; }
        public class DescribeNetworkFlowTopNMetricResponseBodyTopNMetaData : TeaModel {
            /// <summary>
            /// <para>The query time range.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTopNMetricResponseBodyTopNMetaDataDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTopNMetricResponseBodyTopNMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end time of the query range (Unix timestamp, seconds). Same as the EndDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query range (Unix timestamp, seconds). Same as the StartDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned data. It is fixed as requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>requests</para>
            /// </summary>
            [NameInMap("Units")]
            [Validation(Required=false)]
            public string Units { get; set; }

        }

    }

}
