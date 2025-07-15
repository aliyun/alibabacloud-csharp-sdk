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
            /// <para>The callback URL that sends monitoring alerts.</para>
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
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of monitored input streams.</para>
            /// </summary>
            [NameInMap("InputList")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList> InputList { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputList : TeaModel {
                /// <summary>
                /// <para>The index.</para>
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
                    /// <para>The fill type. Set this value to none.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("FillMode")]
                    [Validation(Required=false)]
                    public string FillMode { get; set; }

                    /// <summary>
                    /// <para>The position of the layer, in the format of [unk][x,y][unk]. The values of x and y need to be normalized.</para>
                    /// </summary>
                    [NameInMap("PositionNormalized")]
                    [Validation(Required=false)]
                    public List<float?> PositionNormalized { get; set; }

                    /// <summary>
                    /// <para>The reference position of the element. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>topLeft</description></item>
                    /// <item><description>topRight</description></item>
                    /// <item><description>bottomLeft</description></item>
                    /// <item><description>bottomRight</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topLeft</para>
                    /// </summary>
                    [NameInMap("PositionRefer")]
                    [Validation(Required=false)]
                    public string PositionRefer { get; set; }

                    /// <summary>
                    /// <para>The size of the layer. Unit: bytes.</para>
                    /// </summary>
                    [NameInMap("SizeNormalized")]
                    [Validation(Required=false)]
                    public List<float?> SizeNormalized { get; set; }

                }

                /// <summary>
                /// <para>The layout ID, which must start from 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LayoutId")]
                [Validation(Required=false)]
                public int? LayoutId { get; set; }

                /// <summary>
                /// <para>The playback configurations.</para>
                /// </summary>
                [NameInMap("PlayConfig")]
                [Validation(Required=false)]
                public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig PlayConfig { get; set; }
                public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListInputListPlayConfig : TeaModel {
                    /// <summary>
                    /// <para>The volume. Valid values: 0 to 1. The value is rounded to two decimal places.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.50</para>
                    /// </summary>
                    [NameInMap("VolumeRate")]
                    [Validation(Required=false)]
                    public float? VolumeRate { get; set; }

                }

                /// <summary>
                /// <para>The display name of the monitored stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>monitorStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            /// <summary>
            /// <para>The monitoring alert thresholds. The following fields are included:</para>
            /// <list type="bullet">
            /// <item><description>fpsLowThres: the video frame rate alert threshold. The value is a floating-point number.</description></item>
            /// <item><description>brHighThres: the audio/video bitrate alert threshold. The value is a floating-point number.</description></item>
            /// <item><description>eofDurationThresSec: the interruption duration alert threshold. The value is a floating-point number.</description></item>
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
            /// <para>The output resolution template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lp_ld</b>: low definition</description></item>
            /// <item><description><b>lp_sd</b>: standard definition</description></item>
            /// <item><description><b>lp_hd</b>: high definition</description></item>
            /// <item><description><b>lp_ud</b>: ultra-high definition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lp_ud</para>
            /// </summary>
            [NameInMap("OutputTemplate")]
            [Validation(Required=false)]
            public string OutputTemplate { get; set; }

            /// <summary>
            /// <para>The output URLs.</para>
            /// </summary>
            [NameInMap("OutputUrls")]
            [Validation(Required=false)]
            public DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls OutputUrls { get; set; }
            public class DescribeLiveStreamMonitorListResponseBodyLiveStreamMonitorListOutputUrls : TeaModel {
                /// <summary>
                /// <para>The output URL in the Flash Video (FLV) format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****.flv">http://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****.flv</a></para>
                /// </summary>
                [NameInMap("FlvUrl")]
                [Validation(Required=false)]
                public string FlvUrl { get; set; }

                /// <summary>
                /// <para>The output URL in the Real-Time Messaging Protocol (RTMP) format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://demo.aliyundoc.com/monitor/445409ec-7eaa-461d-8f29-4bec2eb9****</para>
                /// </summary>
                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cn-shanghai: China (Shanghai)</description></item>
            /// <item><description>cn-beijing: China (Beijing)</description></item>
            /// <item><description>ap-southeast-1: Singapore</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The start time of live monitoring. The time is displayed in UTC.</para>
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
            /// <item><description>1: Monitoring</description></item>
            /// <item><description>0: Unmonitored</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The end time of live monitoring. The time is displayed in UTC.</para>
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
        /// <para>The number of monitoring sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
