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
            /// <para>Returns additional information, such as the country, province, and city to which an IP address belongs. It\&quot;s currently empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The value of this field varies depending on the queried Metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8v****a-443-ecs (Protected object)</para>
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
        /// <para>The request ID.</para>
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
                /// <para>The end time of the query range (in UNIX timestamp, seconds). Same as the EndDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time of the query range (in UNIX timestamp, seconds). Same as the StartDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned data. Defaults to the value: request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request</para>
            /// </summary>
            [NameInMap("Units")]
            [Validation(Required=false)]
            public string Units { get; set; }

        }

    }

}
