// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelOverallDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Basic communication information.</para>
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeChannelOverallDataResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// <para>Application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rjdhtnqy</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Communication status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><para><b>IN</b>: In progress.  </para>
            /// </description></item>
            /// <item><description><para><b>OUT</b>: Ended.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the channel was created, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615860711</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the channel was released, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615860811</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>Channel duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <para>List of metric data.</para>
        /// </summary>
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelOverallDataResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelOverallDataResponseBodyMetricDatas : TeaModel {
            /// <summary>
            /// <para>List of coordinate points for the Trend Indicator.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelOverallDataResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelOverallDataResponseBodyMetricDatasNodes : TeaModel {
                /// <summary>
                /// <para>Extension data.</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>X-axis coordinate in the Trend Indicator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1612418625</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>Y-axis coordinate in the Trend Indicator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>Metric Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CALL_QUALITY</b>: Call quality.</description></item>
            /// <item><description><b>CONN_NUM</b>: Distribution of time intervals for successful channel joins.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CALL_QUALITY</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Overview data.</para>
        /// </summary>
        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelOverallDataResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <para>Average communication connection time, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ConnAvgTime")]
            [Validation(Required=false)]
            public float? ConnAvgTime { get; set; }

            /// <summary>
            /// <para>Connection success rate within 5 seconds, represented as a decimal. For example, 1.0 indicates a 100% connection success rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.91</para>
            /// </summary>
            [NameInMap("FiveSecJoinRate")]
            [Validation(Required=false)]
            public float? FiveSecJoinRate { get; set; }

            /// <summary>
            /// <para>Overall audio stuttering rate, represented as a decimal. For example, 0.02 indicates an audio stuttering rate of 2%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalAudioStuckRate")]
            [Validation(Required=false)]
            public float? TotalAudioStuckRate { get; set; }

            /// <summary>
            /// <para>Overall video stuttering rate, represented as a decimal. For example, 0.02 indicates a video stuttering rate of 2%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalVideoStuckRate")]
            [Validation(Required=false)]
            public float? TotalVideoStuckRate { get; set; }

            /// <summary>
            /// <para>Overall video blur rate, represented as a decimal. For example, 0.02 indicates a video blur rate of 2%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalVideoVagueRate")]
            [Validation(Required=false)]
            public float? TotalVideoVagueRate { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
