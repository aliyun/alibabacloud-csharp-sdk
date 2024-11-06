// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUserMetricsResponseBody : TeaModel {
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelUserMetricsResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelUserMetricsResponseBodyMetricDatas : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelUserMetricsResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelUserMetricsResponseBodyMetricDatasNodes : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1612418625</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL_NUM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelUserMetricsResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelUserMetricsResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBadExpNum")]
            [Validation(Required=false)]
            public long? TotalBadExpNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalJoinFailNum")]
            [Validation(Required=false)]
            public long? TotalJoinFailNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPubUserNum")]
            [Validation(Required=false)]
            public long? TotalPubUserNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalSubUserNum")]
            [Validation(Required=false)]
            public long? TotalSubUserNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalUserNum")]
            [Validation(Required=false)]
            public long? TotalUserNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
