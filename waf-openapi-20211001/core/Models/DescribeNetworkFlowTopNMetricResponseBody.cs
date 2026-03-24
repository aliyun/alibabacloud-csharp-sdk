// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTopNMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of the top N statistics.</para>
        /// </summary>
        [NameInMap("NetworkFlowTopNValues")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues> NetworkFlowTopNValues { get; set; }
        public class DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues : TeaModel {
            /// <summary>
            /// <para>The additional attribute associated with the entry. For example, when the Metric is set to real_client_ip, this parameter indicates the country or region to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The dimension value that corresponds to the specified Metric request parameter. For example, if the Metric is set to real_client_ip, this parameter indicates the source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The total number of requests or the QPS value, depending on the specified Metric. This value is used for top N ranking.</para>
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
        /// <para>D827FCFE-90A7-4330-9326-******4C7726</para>
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
            /// <para>The time range used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeNetworkFlowTopNMetricResponseBodyTopNMetaDataDateRange DateRange { get; set; }
            public class DescribeNetworkFlowTopNMetricResponseBodyTopNMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The beginning of the time range. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned statistical data.</para>
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
