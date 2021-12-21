// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeQualityOverallDataResponseBody : TeaModel {
        /// <summary>
        /// 概览数据列表
        /// </summary>
        [NameInMap("QualityOverallData")]
        [Validation(Required=false)]
        public List<DescribeQualityOverallDataResponseBodyQualityOverallData> QualityOverallData { get; set; }
        public class DescribeQualityOverallDataResponseBodyQualityOverallData : TeaModel {
            /// <summary>
            /// 平均值
            /// </summary>
            [NameInMap("Average")]
            [Validation(Required=false)]
            public string Average { get; set; }

            /// <summary>
            /// 坐标点列表
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQualityOverallDataResponseBodyQualityOverallDataNodes> Nodes { get; set; }
            public class DescribeQualityOverallDataResponseBodyQualityOverallDataNodes : TeaModel {
                /// <summary>
                /// x轴横坐标
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// y轴纵坐标
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 概览数据类型，加入频道成功率： JOIN_CHANNEL_SUC_RATE 五秒加入频道成功率： JOIN_CHANNEL_SUC_FIVE_SEC_RATE  首次出声时间： AUDIO_SPEAK_OUT_DUR 首次出图时间： VIDEO_FIRST_PIC_DUR 音频卡顿率： AUDIO_STUCK_RATE 视频卡顿率： VIDEO_STUCK_RATE 音频延时： AUDIO_DELAY 视频延时： AUDIO_DELAY 音频优质传输率： AUDIO_HIGH_QUALITY_TRANSMISSION_RATE 视频优质传输率： VIDEO_HIGH_QUALITY_TRANSMISSION_RATE
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
