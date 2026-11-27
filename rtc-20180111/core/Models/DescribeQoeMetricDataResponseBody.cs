// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQoeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Audio data.</para>
        /// </summary>
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyAudioData> AudioData { get; set; }
        public class DescribeQoeMetricDataResponseBodyAudioData : TeaModel {
            /// <summary>
            /// <para>List of coordinate points for the audio trend indicator.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyAudioDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyAudioDataNodes : TeaModel {
                /// <summary>
                /// <para>X-axis coordinate in the audio trend indicator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548670256</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>Y-axis coordinate in the audio trend indicator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>Communication experience. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>AUDIO</b>: Audio bitrate.  </description></item>
            /// <item><description><b>AUDIO_STUCK</b>: Audio downlink stuttering.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIO</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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

        /// <summary>
        /// <para>Video data.</para>
        /// </summary>
        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyVideoData> VideoData { get; set; }
        public class DescribeQoeMetricDataResponseBodyVideoData : TeaModel {
            /// <summary>
            /// <para>List of coordinate points for the video metric trend graph.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyVideoDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyVideoDataNodes : TeaModel {
                /// <summary>
                /// <para>The x-axis coordinate in the video metric trend graph.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548670256</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The y-axis coordinate in the Video Trend Indicator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// <para>The type of metric that impacts communication experience. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VIDEO_CAMERA</b>: Camera bitrate.</description></item>
            /// <item><description><b>VIDEO_SCREEN_SHARE</b>: Screen sharing stream bitrate.</description></item>
            /// <item><description><b>VIDEO_STUCK_CAMERA</b>: Camera stuttering.</description></item>
            /// <item><description><b>VIDEO_STUCK_SCREEN_SHARE</b>: Screen sharing stuttering.</description></item>
            /// <item><description><b>VIDEO_VAGUE_CAMERA</b>: Camera blur.</description></item>
            /// <item><description><b>VIDEO_VAGUE_SCREEN_SHARE</b>: Screen sharing blur.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIDEO_CAMERA</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuserid</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
