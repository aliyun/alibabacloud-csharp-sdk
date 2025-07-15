// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListRtcMPUTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameters that you configured when you called the StartLiveMPUTask operation to create the tasks.</para>
        /// </summary>
        [NameInMap("MPUTasks")]
        [Validation(Required=false)]
        public List<ListRtcMPUTaskDetailResponseBodyMPUTasks> MPUTasks { get; set; }
        public class ListRtcMPUTaskDetailResponseBodyMPUTasks : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAppId</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourChannelId</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The timeout period of an idle connection. Unit: seconds.</para>
            /// <remarks>
            /// <para> If the task is idle for a period of time longer than the duration specified by the MaxIdleTime parameter, the task is automatically stopped. If the parameter is not specified, the task is stopped after the channel is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxIdleTime")]
            [Validation(Required=false)]
            public string MaxIdleTime { get; set; }

            /// <summary>
            /// <para>The stream mixing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: relays the original single stream without mixing streams. If the value of this parameter is 0, the TranscodeParams parameter is empty.</description></item>
            /// <item><description>1 (default): mixes multiple streams into a single stream and relays the mixed stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MixMode")]
            [Validation(Required=false)]
            public string MixMode { get; set; }

            /// <summary>
            /// <para>The multiple ingest URLs relayed.</para>
            /// </summary>
            [NameInMap("MultiStreamURL")]
            [Validation(Required=false)]
            public List<ListRtcMPUTaskDetailResponseBodyMPUTasksMultiStreamURL> MultiStreamURL { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksMultiStreamURL : TeaModel {
                /// <summary>
                /// <para>Indicates whether stream relay is performed by using Alibaba Cloud CDN. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: Stream relay is performed by using a CDN service that is not Alibaba Cloud CDN.</description></item>
                /// <item><description>true: Stream relay is performed by using Alibaba Cloud CDN.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsAliCdn")]
                [Validation(Required=false)]
                public bool? IsAliCdn { get; set; }

                /// <summary>
                /// <para>The ingest URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://example.com/live/stream****</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The region in which the streams are mixed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CN-shanghai</b></description></item>
            /// <item><description><b>AP-Singapore (default)</b></description></item>
            /// <item><description><b>EMAA-Saudi</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN-Shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The supplemental enhancement information (SEI) parameters.</para>
            /// </summary>
            [NameInMap("SeiParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParams SeiParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParams : TeaModel {
                /// <summary>
                /// <para>The layout and volume SEI. If the return value is an empty string, the default layout and volume SEI is used.</para>
                /// </summary>
                [NameInMap("LayoutVolume")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsLayoutVolume LayoutVolume { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsLayoutVolume : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to add SEI messages to Instantaneous Decoder Refresh (IDR) frames. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: does not add SEI messages.</description></item>
                    /// <item><description>1: adds SEI messages.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FollowIdr")]
                    [Validation(Required=false)]
                    public string FollowIdr { get; set; }

                    /// <summary>
                    /// <para>The interval at which the SEI messages are added. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                }

                /// <summary>
                /// <para>The custom SEI.</para>
                /// </summary>
                [NameInMap("PassThrough")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsPassThrough PassThrough { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksSeiParamsPassThrough : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether to add SEI messages to Instantaneous Decoder Refresh (IDR) frames. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: does not add SEI messages.</description></item>
                    /// <item><description>1: adds SEI messages.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FollowIdr")]
                    [Validation(Required=false)]
                    public string FollowIdr { get; set; }

                    /// <summary>
                    /// <para>The interval at which the SEI messages are added. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    /// <summary>
                    /// <para>The payload content of the custom SEI.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPayloadContent</para>
                    /// </summary>
                    [NameInMap("PayloadContent")]
                    [Validation(Required=false)]
                    public string PayloadContent { get; set; }

                    /// <summary>
                    /// <para>The key of the payload content. Default value: udd.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPayloadContentKey</para>
                    /// </summary>
                    [NameInMap("PayloadContentKey")]
                    [Validation(Required=false)]
                    public string PayloadContentKey { get; set; }

                }

                /// <summary>
                /// <para>The custom payload type. Valid values: 100 to 254. Default value: 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PayloadType")]
                [Validation(Required=false)]
                public string PayloadType { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the single-stream relay task.</para>
            /// </summary>
            [NameInMap("SingleSubParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksSingleSubParams SingleSubParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksSingleSubParams : TeaModel {
                /// <summary>
                /// <para>The source of the video. This parameter is valid only if you set StreamType to 2. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>camera (default): captures the video by using a camera.</description></item>
                /// <item><description>shareScreen: captures the content displayed on a screen.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>camera</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the stream that is relayed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0 (default): the original stream.</description></item>
                /// <item><description>1: the audio-only stream.</description></item>
                /// <item><description>2: the video-only stream.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// <para>The ID of the user whose stream is relayed. In single-stream relay mode, you can relay only one stream in a request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourSubUserId</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The ingest URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://example.com/live/stream****</para>
            /// </summary>
            [NameInMap("StreamURL")]
            [Validation(Required=false)]
            public string StreamURL { get; set; }

            /// <summary>
            /// <para>The ID of the stream relay task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourTaskId</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The mixed-stream relay parameters.</para>
            /// </summary>
            [NameInMap("TranscodeParams")]
            [Validation(Required=false)]
            public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParams TranscodeParams { get; set; }
            public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParams : TeaModel {
                /// <summary>
                /// <para>The global background image.</para>
                /// </summary>
                [NameInMap("Background")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsBackground Background { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsBackground : TeaModel {
                    /// <summary>
                    /// <para>The display mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: proportionally scales the video or background image to fit the pane. Black bars are added to fill the extra space.</description></item>
                    /// <item><description>1 (default): crops the video or background image to fit the pane.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public string RenderMode { get; set; }

                    /// <summary>
                    /// <para>The URL of the global background image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourImageUrl</para>
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                /// <summary>
                /// <para>The encoding parameters of the output stream.</para>
                /// </summary>
                [NameInMap("EncodeParams")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsEncodeParams EncodeParams { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsEncodeParams : TeaModel {
                    /// <summary>
                    /// <para>The bitrate of the audio. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("AudioBitrate")]
                    [Validation(Required=false)]
                    public string AudioBitrate { get; set; }

                    /// <summary>
                    /// <para>The number of audio channels. Valid values: 1 and 2.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AudioChannels")]
                    [Validation(Required=false)]
                    public string AudioChannels { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the output stream is an audio-only stream. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false (default)</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AudioOnly")]
                    [Validation(Required=false)]
                    public string AudioOnly { get; set; }

                    /// <summary>
                    /// <para>The audio sampling rate. Unit: Hz.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("AudioSampleRate")]
                    [Validation(Required=false)]
                    public string AudioSampleRate { get; set; }

                    /// <summary>
                    /// <para>The parameter for advanced video encoding. The value is a JSON string. Optional fields:</para>
                    /// <list type="bullet">
                    /// <item><description>profile: the encoding level. If the video encoding format is set to H.264, the valid values of this field are baseline, main, and high.</description></item>
                    /// <item><description>preset: adjusts the trade-off between encoding speed and video quality. Valid values: ultrafast, superfast, veryfast, faster, fast, medium, slow, slower, veryslow, and placebo. Each value specifies a level of trade-off between encoding speed and video quality. For example, the ultrafast preset has the fastest encoding speed but the lowest video quality, while the placebo preset sacrifices the encoding speed for the best video quality.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;profile&quot;: &quot;high&quot;, &quot;preset&quot;: &quot;veryfast&quot;}</para>
                    /// </summary>
                    [NameInMap("EnhancedParam")]
                    [Validation(Required=false)]
                    public string EnhancedParam { get; set; }

                    /// <summary>
                    /// <para>The bitrate of the video. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3500</para>
                    /// </summary>
                    [NameInMap("VideoBitrate")]
                    [Validation(Required=false)]
                    public string VideoBitrate { get; set; }

                    /// <summary>
                    /// <para>The video encoding format. Default value: H.264.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264</para>
                    /// </summary>
                    [NameInMap("VideoCodec")]
                    [Validation(Required=false)]
                    public string VideoCodec { get; set; }

                    /// <summary>
                    /// <para>The frame rate of the video. Unit: frames per second (FPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("VideoFramerate")]
                    [Validation(Required=false)]
                    public string VideoFramerate { get; set; }

                    /// <summary>
                    /// <para>The group of pictures (GOP) size of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("VideoGop")]
                    [Validation(Required=false)]
                    public string VideoGop { get; set; }

                    /// <summary>
                    /// <para>The height of the video. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("VideoHeight")]
                    [Validation(Required=false)]
                    public string VideoHeight { get; set; }

                    /// <summary>
                    /// <para>The width of the video. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1920</para>
                    /// </summary>
                    [NameInMap("VideoWidth")]
                    [Validation(Required=false)]
                    public string VideoWidth { get; set; }

                }

                /// <summary>
                /// <para>The video layout information.</para>
                /// <remarks>
                /// <para> The video layout information includes the x-coordinate, y-coordinate, width, height, and layer of the pane. For audio-only transcoding, no video layout information is returned.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Layout")]
                [Validation(Required=false)]
                public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayout Layout { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayout : TeaModel {
                    /// <summary>
                    /// <para>The information about the panes.</para>
                    /// </summary>
                    [NameInMap("UserPanes")]
                    [Validation(Required=false)]
                    public List<ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanes> UserPanes { get; set; }
                    public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanes : TeaModel {
                        /// <summary>
                        /// <para>The URL of the background image of the pane. This image is displayed if the user turns off the camera or is not present in the channel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yourImageUrl</para>
                        /// </summary>
                        [NameInMap("BackgroundImageUrl")]
                        [Validation(Required=false)]
                        public string BackgroundImageUrl { get; set; }

                        /// <summary>
                        /// <para>The height of the pane. The value is normalized.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2632</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The display mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: proportionally scales the video or background image to fit the pane. Black bars are added to fill the extra space.</description></item>
                        /// <item><description>1 (default): crops the video or background image to fit the pane.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("RenderMode")]
                        [Validation(Required=false)]
                        public string RenderMode { get; set; }

                        /// <summary>
                        /// <para>The information about the user whose stream is played in the pane.</para>
                        /// </summary>
                        [NameInMap("UserInfo")]
                        [Validation(Required=false)]
                        public ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanesUserInfo UserInfo { get; set; }
                        public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsLayoutUserPanesUserInfo : TeaModel {
                            /// <summary>
                            /// <para>The ID of the channel where the user is.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yourChannelId</para>
                            /// </summary>
                            [NameInMap("ChannelId")]
                            [Validation(Required=false)]
                            public string ChannelId { get; set; }

                            /// <summary>
                            /// <para>The source of the video. This parameter is valid only if you set StreamType to 2. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>camera (default): captures the video by using a camera.</description></item>
                            /// <item><description>shareScreen: captures the content displayed on a screen.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>camera</para>
                            /// </summary>
                            [NameInMap("SourceType")]
                            [Validation(Required=false)]
                            public string SourceType { get; set; }

                            /// <summary>
                            /// <para>The ID of the user.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yourSubUserId</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public string UserId { get; set; }

                        }

                        /// <summary>
                        /// <para>The width of the pane. The value is normalized.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.3564</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        /// <summary>
                        /// <para>The x-coordinate of the pane. The value is normalized.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2456</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public string X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate of the pane. The value is normalized.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.3789</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public string Y { get; set; }

                        /// <summary>
                        /// <para>The layer of the pane. A value of 0 indicates that the pane is placed at the bottom layer. A larger value indicates a higher layer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ZOrder")]
                        [Validation(Required=false)]
                        public string ZOrder { get; set; }

                    }

                }

                /// <summary>
                /// <para>The information about the user whose stream is mixed. If an empty value is returned, streams from all users are mixed.</para>
                /// </summary>
                [NameInMap("UserInfos")]
                [Validation(Required=false)]
                public List<ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsUserInfos> UserInfos { get; set; }
                public class ListRtcMPUTaskDetailResponseBodyMPUTasksTranscodeParamsUserInfos : TeaModel {
                    /// <summary>
                    /// <para>The ID of the channel where the user is.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourChannelId</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public string ChannelId { get; set; }

                    /// <summary>
                    /// <para>The source of the video. This parameter is valid only if you set StreamType to 2. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>camera (default): captures the video by using a camera.</description></item>
                    /// <item><description>shareScreen: captures the content displayed on a screen.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>camera</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                    /// <summary>
                    /// <para>The type of the stream that is relayed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0 (default): the original stream.</description></item>
                    /// <item><description>1: the audio-only stream.</description></item>
                    /// <item><description>2: the video-only stream.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public string StreamType { get; set; }

                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourSubUserId</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
