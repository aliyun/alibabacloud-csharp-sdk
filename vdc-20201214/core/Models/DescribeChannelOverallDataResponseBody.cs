// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelOverallDataResponseBody : TeaModel {
        /// <summary>
        /// 通信基本信息。
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeChannelOverallDataResponseBodyCallInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
        };

        /// <summary>
        /// 指标数据列表。
        /// </summary>
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelOverallDataResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelOverallDataResponseBodyMetricDatas : TeaModel {
            /// <summary>
            /// 指标趋势图坐标点列表。
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelOverallDataResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelOverallDataResponseBodyMetricDatasNodes : TeaModel {
                /// <summary>
                /// 扩展数据
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// 指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 指标趋势图中y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 指标类型，取值：CALL_QUALITY：通信质量。CONN_NUM：通信次数。
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 概览数据。
        /// </summary>
        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelOverallDataResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelOverallDataResponseBodyOverallData : TeaModel {
            [NameInMap("ConnAvgTime")]
            [Validation(Required=false)]
            public float? ConnAvgTime { get; set; }
            [NameInMap("FiveSecJoinRate")]
            [Validation(Required=false)]
            public float? FiveSecJoinRate { get; set; }
            [NameInMap("TotalAudioStuckRate")]
            [Validation(Required=false)]
            public float? TotalAudioStuckRate { get; set; }
            [NameInMap("TotalVideoStuckRate")]
            [Validation(Required=false)]
            public float? TotalVideoStuckRate { get; set; }
            [NameInMap("TotalVideoVagueRate")]
            [Validation(Required=false)]
            public float? TotalVideoVagueRate { get; set; }
        };

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
