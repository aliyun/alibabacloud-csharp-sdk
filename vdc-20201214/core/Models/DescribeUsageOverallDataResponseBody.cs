// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeUsageOverallDataResponseBody : TeaModel {
        /// <summary>
        /// 用量概览数据列表
        /// </summary>
        [NameInMap("UsageOverallData")]
        [Validation(Required=false)]
        public List<DescribeUsageOverallDataResponseBodyUsageOverallData> UsageOverallData { get; set; }
        public class DescribeUsageOverallDataResponseBodyUsageOverallData : TeaModel {
            /// <summary>
            /// 类型，半角逗号分隔    总时长：TOTAL_CALL_DURATION  视频通信时长：VIDEO_CALL_DURATION  音频通信时长：AUDIO_CALL_DURATION    通信频道数：CALL_CHANNEL_COUNT  高并发通信频道数：  HIGHLY_CONCURRENT_CHANNEL_COUNT  并发频道数峰值：  CHANNEL_CONCURRENT_PEAK    在线人数峰值：ONLINE_USER_PEAK  累计通话人数：  TOTAL_CALL_USER  累计进出人次：  TOTAL_INOUT_NUM
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 坐标点列表
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeUsageOverallDataResponseBodyUsageOverallDataNodes> Nodes { get; set; }
            public class DescribeUsageOverallDataResponseBodyUsageOverallDataNodes : TeaModel {
                /// <summary>
                /// x轴横坐标
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// y轴横坐标
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
