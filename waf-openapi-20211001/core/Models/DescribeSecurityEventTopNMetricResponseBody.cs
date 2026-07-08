// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTopNMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D827FCFE-90A7-4330-9326-*****B4C7726</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of top N statistics.</para>
        /// </summary>
        [NameInMap("SecurityEventTopNValues")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventTopNMetricResponseBodySecurityEventTopNValues> SecurityEventTopNValues { get; set; }
        public class DescribeSecurityEventTopNMetricResponseBodySecurityEventTopNValues : TeaModel {
            /// <summary>
            /// <para>The additional information, such as the protection module to which a rule ID belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_base</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The value of a specific field. The meaning varies depending on the queried Metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The statistical count used for top N sorting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        /// <summary>
        /// <para>The metadata of the returned data.</para>
        /// </summary>
        [NameInMap("TopNMetaData")]
        [Validation(Required=false)]
        public DescribeSecurityEventTopNMetricResponseBodyTopNMetaData TopNMetaData { get; set; }
        public class DescribeSecurityEventTopNMetricResponseBodyTopNMetaData : TeaModel {
            /// <summary>
            /// <para>The time range used for the query.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventTopNMetricResponseBodyTopNMetaDataDateRange DateRange { get; set; }
            public class DescribeSecurityEventTopNMetricResponseBodyTopNMetaDataDateRange : TeaModel {
                /// <summary>
                /// <para>The end time used for querying data, expressed as a UNIX timestamp. Unit: seconds. This value is the same as the EndDate in the request parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start time used for querying data, expressed as a UNIX timestamp. Unit: seconds. This value is the same as the StartDate in the request parameters.</para>
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
