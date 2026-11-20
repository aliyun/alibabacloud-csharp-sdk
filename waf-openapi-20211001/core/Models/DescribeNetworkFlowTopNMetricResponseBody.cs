// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTopNMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of returned top statistics.</para>
        /// </summary>
        [NameInMap("NetworkFlowTopNValues")]
        [Validation(Required=false)]
        public List<DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues> NetworkFlowTopNValues { get; set; }
        public class DescribeNetworkFlowTopNMetricResponseBodyNetworkFlowTopNValues : TeaModel {
            /// <summary>
            /// <para>The additional information returned, such as the country, province, and city to which an IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The value of a field. The meaning varies depending on the queried metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The statistical count used for top sorting.</para>
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
                /// <para>The end time used for the data query. The end time is represented by a UNIX timestamp in seconds. This value is the same as the EndDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time used for the data query. The start time is represented by a UNIX timestamp in seconds. This value is the same as the StartDate request parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            /// <summary>
            /// <para>The unit of the returned statistics.</para>
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
