// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUserMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The metric data list.</para>
        /// </summary>
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelUserMetricsResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelUserMetricsResponseBodyMetricDatas : TeaModel {
            /// <summary>
            /// <para>The list of coordinate points in the metric trends chart.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelUserMetricsResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelUserMetricsResponseBodyMetricDatasNodes : TeaModel {
                /// <summary>
                /// <para>The extended properties.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>The x-axis coordinate in the metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1612418625</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the metric trends chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>The metric type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL_NUM</b>: the number of users per unit of time.</description></item>
            /// <item><description><b>PUB_NUM</b>: the number of publishing users per unit of time.</description></item>
            /// <item><description><b>SUB_NUM</b>: the number of subscribing users per unit of time.</description></item>
            /// <item><description><b>JOIN_FAIL_NUM</b>: the number of users who failed to join the channel per unit of time.</description></item>
            /// <item><description><b>BAD_EXP_NUM</b>: the number of users with abnormal communication experience per unit of time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_NUM</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The overview data.</para>
        /// </summary>
        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelUserMetricsResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelUserMetricsResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <para>The total number of users with abnormal communication experience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBadExpNum")]
            [Validation(Required=false)]
            public long? TotalBadExpNum { get; set; }

            /// <summary>
            /// <para>The total number of users who failed to join the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalJoinFailNum")]
            [Validation(Required=false)]
            public long? TotalJoinFailNum { get; set; }

            /// <summary>
            /// <para>The total number of publishing users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPubUserNum")]
            [Validation(Required=false)]
            public long? TotalPubUserNum { get; set; }

            /// <summary>
            /// <para>The total number of subscribing users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalSubUserNum")]
            [Validation(Required=false)]
            public long? TotalSubUserNum { get; set; }

            /// <summary>
            /// <para>The total number of users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalUserNum")]
            [Validation(Required=false)]
            public long? TotalUserNum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
