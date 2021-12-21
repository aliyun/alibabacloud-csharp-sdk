// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeQoeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// 音频数据。
        /// </summary>
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyAudioData> AudioData { get; set; }
        public class DescribeQoeMetricDataResponseBodyAudioData : TeaModel {
            /// <summary>
            /// 音频指标趋势图坐标点列表。
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyAudioDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyAudioDataNodes : TeaModel {
                /// <summary>
                /// 音频指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 音频指标趋势图中y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 通信体验，取值：AUDIO：音频码率。AUDIO_STUCK：音频下行卡顿。
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 视频数据。
        /// </summary>
        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyVideoData> VideoData { get; set; }
        public class DescribeQoeMetricDataResponseBodyVideoData : TeaModel {
            /// <summary>
            /// 视频指标趋势图坐标点列表。
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyVideoDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyVideoDataNodes : TeaModel {
                /// <summary>
                /// 视频指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 视频指标趋势图中y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 通信体验，取值：VIDEO_CAMERA：摄像头码率。VIDEO_CAMERA_LARGE：摄像头大流码率。VIDEO_CAMERA_SMALL：摄像头小流码率。VIDEO_CAMERA_SUPER：摄像头超大流码率。VIDEO_SCREEN_SHARE：共享屏幕流码率。VIDEO_STUCK_CAMERA：摄像头卡顿。VIDEO_STUCK_CAMERA_LARGE：摄像头大流卡顿。VIDEO_STUCK_CAMERA_SMALL：摄像头小流卡顿。VIDEO_STUCK_CAMERA_SUPER：摄像头超大流卡顿。VIDEO_STUCK_SCREEN_SHARE：屏幕共享卡顿。VIDEO_VAGUE_CAMERA：摄像头模糊。VIDEO_VAGUE_CAMERA_LARGE：摄像头大流模糊。VIDEO_VAGUE_CAMERA_SMALL：摄像头小流模糊。VIDEO_VAGUE_CAMERA_SUPER：摄像头超大流模糊。VIDEO_VAGUE_SCREEN_SHARE：屏幕共享模糊。
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
