// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelOverallDataResponseBody : TeaModel {
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeChannelOverallDataResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>rjdhtnqy</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1615860711</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1615860811</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelOverallDataResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelOverallDataResponseBodyMetricDatas : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelOverallDataResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelOverallDataResponseBodyMetricDatasNodes : TeaModel {
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
            /// <para>CALL_QUALITY</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelOverallDataResponseBodyOverallData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ConnAvgTime")]
            [Validation(Required=false)]
            public float? ConnAvgTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.91</para>
            /// </summary>
            [NameInMap("FiveSecJoinRate")]
            [Validation(Required=false)]
            public float? FiveSecJoinRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalAudioStuckRate")]
            [Validation(Required=false)]
            public float? TotalAudioStuckRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalVideoStuckRate")]
            [Validation(Required=false)]
            public float? TotalVideoStuckRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.02</para>
            /// </summary>
            [NameInMap("TotalVideoVagueRate")]
            [Validation(Required=false)]
            public float? TotalVideoVagueRate { get; set; }

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
