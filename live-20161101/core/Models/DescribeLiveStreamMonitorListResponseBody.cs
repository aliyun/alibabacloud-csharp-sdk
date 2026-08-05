// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMonitorListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of monitoring sessions.</para>
        /// </summary>
        [NameInMap("LiveStreamMonitorList")]
        [Validation(Required=false)]
        public List<DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorList> LiveStreamMonitorList { get; set; }
        public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorList : TeaModel {
            /// <summary>
            /// <para>The audio source in the layout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AudioFrom")]
            [Validation(Required=false)]
            public int? AudioFrom { get; set; }

            /// <summary>
            /// <para>The webhook address for monitoring alert notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>The URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa">https://oapi.dingtalk.com/robot/send?access_token=7a7d404056eee1f2fd944ace9bcfc361dc6448583e1d3d3baa</a>****</para>
            /// </summary>
            [NameInMap("DingTalkWebHookUrl")]
            [Validation(Required=false)]
            public string DingTalkWebHookUrl { get; set; }

            /// <summary>
            /// <para>The output domain name for monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of input streams for monitoring.</para>
            /// </summary>
            [NameInMap("InputList")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList> InputList { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList : TeaModel {
                /// <summary>
                /// <para>The index. This parameter is used by the frontend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The URL of the input stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                /// <summary>
                /// <para>The layout information.</para>
                /// </summary>
                [NameInMap("LayoutConfig")]
                [Validation(Required=false)]
                public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListLayoutConfig LayoutConfig { get; set; }
                public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListLayoutConfig : TeaModel {
                    /// <summary>
                    /// <para>The fill mode. For frontend development, set this parameter to none.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("FillMode")]
                    [Validation(Required=false)]
                    public string FillMode { get; set; }

                    /// <summary>
                    /// <para>The normalized coordinates of the element\&quot;s position, in the format of [x,y]. The default value is [0,0]. The values of x and y must be normalized.</para>
                    /// </summary>
                    [NameInMap("PositionNormalized")]
                    [Validation(Required=false)]
                    public List<float?> PositionNormalized { get; set; }

                    /// <summary>
                    /// <para>The reference point for the element\&quot;s position. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>topLeft</para>
                    /// </description></item>
                    /// <item><description><para>topRight</para>
                    /// </description></item>
                    /// <item><description><para>bottomLeft</para>
                    /// </description></item>
                    /// <item><description><para>bottomRight</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topLeft</para>
                    /// </summary>
                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    /// <summary>
                    /// <para>The normalized size of the element\&quot;s fill area, in the format of [w,h].</para>
                    /// </summary>
                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public List<float?> SizeNormalized { get; set; }

                }

                /// <summary>
                /// <para>The layout ID. The value must start from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public int? LayoutId { get; set; }

                /// <summary>
                /// <para>The playback configuration.</para>
                /// </summary>
                [NameInMap("PlayConfig")]
                [Validation(Required=false)]
                public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig PlayConfig { get; set; }
                public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig : TeaModel {
                    /// <summary>
                    /// <para>The volume. The value must be between 0 and 1, inclusive, with up to two decimal places.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.50</para>
                    /// </summary>
                    [NameInMap("VolumeRate")]
                    [Validation(Required=false)]
                    public float? VolumeRate { get; set; }

                }

                /// <summary>
                /// <para>The display name of the stream for monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>monitorStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            /// <summary>
            /// <para>The settings for monitoring alert thresholds. The value is a JSON string that includes the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para>fpsLowThres: the alert threshold for the video frame rate. This is a float.</para>
            /// </description></item>
            /// <item><description><para>brHighThres: the alert threshold for the audio and video bitrate. This is a float.</para>
            /// </description></item>
            /// <item><description><para>eofDurationThresSec: the alert threshold for the stream interruption duration. This is a float.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;fpsLowThres\&quot;: 0.6,\&quot;brLowThres\&quot;: 1.1,\&quot;eofDurationThresSec\&quot;: 10}&quot;</para>
            /// </summary>
            [NameInMap("MonitorConfig")]
            [Validation(Required=false)]
            public string MonitorConfig { get; set; }

            /// <summary>
            /// <para>The ID of the monitoring session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
            /// </summary>
            [NameInMap("MonitorId")]
            [Validation(Required=false)]
            public string MonitorId { get; set; }

            /// <summary>
            /// <para>The name of the monitoring session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveMonito****</para>
            /// </summary>
            [NameInMap("MonitorName")]
            [Validation(Required=false)]
            public string MonitorName { get; set; }

            /// <summary>
            /// <para>The template for the output resolution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>lp_ld</b>: low definition</para>
            /// </description></item>
            /// <item><description><para><b>lp_sd</b>: standard definition</para>
            /// </description></item>
            /// <item><description><para><b>lp_hd</b>: high definition</para>
            /// </description></item>
            /// <item><description><para><b>lp_ud</b>: ultra-high definition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lp_ud</para>
            /// </summary>
            [NameInMap("OutputTemplate")]
            [Validation(Required=false)]
            public string OutputTemplate { get; set; }

            /// <summary>
            /// <para>The output URLs for monitoring.</para>
            /// </summary>
            [NameInMap("OutputUrls")]
            [Validation(Required=false)]
            public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls OutputUrls { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls : TeaModel {
                /// <summary>
                /// <para>The output URL in FLV format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****.flv">http://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****.flv</a></para>
                /// </summary>
                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                /// <summary>
                /// <para>The output URL in RTMP format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****</para>
                /// </summary>
                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

            }

            /// <summary>
            /// <para>The region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cn-shanghai: China (Shanghai)</para>
            /// </description></item>
            /// <item><description><para>cn-beijing: China (Beijing)</para>
            /// </description></item>
            /// <item><description><para>ap-southeast-1: Singapore</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when monitoring starts. The time is in UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the monitoring session. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The session is being monitored.</para>
            /// </description></item>
            /// <item><description><para>0: The session is not being monitored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when monitoring stops. The time is in UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2234baba-a586-46ea-8bd4-c8f7891abcdef</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of monitoring sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
